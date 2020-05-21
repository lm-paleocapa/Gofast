class Contact {
		constructor(image, name, id, online, lastLog, messages) {
			this.image = image;
			this.name = name;
			this.id = id;
			this.online = online;
			this.lastLog = lastLog;
			this.messages = messages;
		}
	}

	class Message {
		constructor(content, time, mode) {
			this.content = content;
			this.time = time;
			this.mode = mode;
		}
	}
	
	var contacts = [];
	var activeChat = 0;
	var userID = 6;
	var userImage;
	var email;
	var password;
	var webSocket;
	var webSocketAddress = "ws://80.182.17.185:8181";
	var username;
	var contactSelected = false;

	function loadFriendshipRequests(data) {
		for(var i = 0; i < data.length; i++) {
			if(data.name != null)
				addFriendshipRequest(data.name, data.image);
		}
	}

	function getData(data) {
		email = data.email;
		password = data.password;
		userImage = "data:image/png; base64, " + data.image;
		id = data.id;
		username = data.username;
		setupWebSocket();
	}

	function loadContacts(data) {
		for (var i = 0; i < data.length; i++) {
			let online = false;
			let lastlog;
			if (data[i].state === "online") {
				online = true;
				lastlog = "online";
			}
			else
				lastlog = data[i].state;
			contacts.push(new Contact("data:image/png; base64, " + data[i].image, data[i].name, data[i].id, online, lastlog, []));
		}
		for (var i = 0; i < contacts.length; i++) {
			addContact(contacts[i].image, contacts[i].name, contacts[i].id, contacts[i].online, contacts[i].lastLog);
		}
		loadMessagesFromDatabase(0);
	}

	function reloadContacts(data) {
		contacts = [];
		var contactsList = document.getElementById("contactsList");
		for(var i = 0; i < contactsList.children.length; i++) {
			if(contactsList.children[i].hasAttribute("id")){
				contactsList.removeChild(contactsList.children[i]);
				i--;
			}
		}
		loadContacts(data);
	}

	function searchContacts() {
		var contactsList = document.getElementById("contactsList");
		for(var i = 0; i < contactsList.children.length; i++) {
						if(contactsList.children[i].hasAttribute("id")) {
								contactsList.removeChild(contactsList.children[1]);
								i--;
						}
		}

		for(var i = 0; i < contacts.length; i++) {
			if(contacts[i].name.includes(document.getElementById("searchContacts").value)) {
								addContact(contacts[i].image, contacts[i].name, contacts[i].id, contacts[i].online, contacts[i].lastLog);
			}
		}
	}

	function manageData(event) {
		var data = JSON.parse(event.data);
		alert(data.id);
		var idFrom;
		for(var i = 0; i < contacts.length; i++) {
			if(contacts[i].name == data.from)
				idFrom = contacts[i].id;
		}
		switch (data.id) {
			case 3:
				getMessage(idFrom, data.message, data.date);
				break;
			case 8:
				if(data.from != null)
					addFriendshipRequest(data.from, "data:image/png; base64, " + data.image);
				break;
			case 9:
				$.getJSON("loadContacts.php", reloadContacts);
				break;
		}
	}

	function setupWebSocket() {
		webSocket = new WebSocket(webSocketAddress);
		webSocket.onmessage = manageData;//function(event) {var data = JSON.parse(event.data); alert(data.message);}
		webSocket.onopen = function(event) {webSocket.send("{'id':'1', 'username':'" + username + "', 'password':'" + password + "'}")};
	}

	function loadMessages(id) {
		for (var i = 0; i < contacts.length; i++) {
			if(contacts[i].id == id) {
				for (var j = 0; j < contacts[i].messages.length; j++) {
					if (contacts[i].messages[j].mode == "SEND")
						viewSentMessage(contacts[i].messages[j].content, contacts[i].messages[j].time);
					else if (contacts[i].messages[j].mode == "RECEIVE")
						viewReceivedMessage(contacts[i].messages[j].content, contacts[i].messages[j].time);
				}
			}
		}
	}

	function loadMessagesFromDatabase(r) {
			var id = contacts[r].id;
			$.getJSON("loadMessages.php?friendId=" + id, function(data) {
                                        	for (var j = 0; j < data.length; j++) {
                                                	contacts[r].messages.push(new Message(data[j].content, data[j].date.split(" ")[1], data[j].mode));
                                        	}
						if (r < contacts.length) {
							r++;
							loadMessagesFromDatabase(r);
						}
                	});
	}

	function addFriendshipRequest(name, image){
		var contactsList = document.getElementById("contactsList");
		var newContact = document.createElement("li");;
		//newContact.onclick = function() { loadContact(name, image, online, id);  newContact.className = "active";};
		contactsList.insertBefore(newContact, contactsList.childNodes[1]);
		var newDiv = document.createElement("div");
		newDiv.className = "d-flex bd-highlight";
		newContact.appendChild(newDiv);
		var newSubDiv0 = document.createElement("div");
		newSubDiv0.className = "img_cont";
		newDiv.appendChild(newSubDiv0);
		var newSubDiv1 = document.createElement("div");
		newSubDiv1.className = "user_info";
		newDiv.appendChild(newSubDiv1);
		var newImg = document.createElement("img");
		newImg.src = image;
		newImg.className = "rounded-circle user_img";
		newSubDiv0.appendChild(newImg);
		var newSpan1 = document.createElement("span");
		newSpan1.innerHTML = name;
		newSubDiv1.appendChild(newSpan1);
		newBr = document.createElement("br");
		newSubDiv1.appendChild(newBr)
		newText = document.createTextNode("wants to be your friend");
		newSubDiv1.appendChild(newText)
		newSubDiv2 = document.createElement("div");
		newSubDiv2.className = "img_cont";
		newDiv.appendChild(newSubDiv2);
		newImg2 = document.createElement("img");
		newImg2.src = "accept.png";
		newImg2.className = "rounded-circle accept_img";
		newImg2.onclick = function() {contactsList.removeChild(newContact); webSocket.send("{'id':'8', 'username':'" + username + "', 'to':'" + name + "'}"); $.getJSON("loadContacts.php", reloadContacts);};
		newSubDiv2.appendChild(newImg2);
		newImg3 = document.createElement("img");
		newImg3.src = "decline.png";
		newImg3.className = "rounded-circle decline_img";
		newImg3.onclick = function() {contactsList.removeChild(newContact); alert("q"); webSocket.send("{'id':'9', 'username':'" + username + "', 'to':'" + name + "'}");};
		newSubDiv2.appendChild(newImg3);
	}

	function sendFriendshipRequest(){
		friendName = document.getElementById("friendToRequest").value;
		document.getElementById("friendToRequest").value = "";
		webSocket.send("{'id':'5', 'username':'" + username + "', 'friends':[{'user':'" + friendName + "'}]}");
	}

	function viewSentMessage(content, time) {
		var messageList = document.getElementById("messageList");
		var newMessage = document.createElement("div");
		newMessage.className = "d-flex justify-content-end mb-4";
		messageList.appendChild(newMessage);
		var newSubDiv0 = document.createElement("div");
		newSubDiv0.className = "msg_container_send";
		newSubDiv0.innerHTML = content;
		newMessage.appendChild(newSubDiv0);
		var newSubDiv1 = document.createElement("div");
		newSubDiv1.className = "img_cont_msg";
		newMessage.appendChild(newSubDiv1);
		newSpan = document.createElement("span");
		newSpan.className = "msg_time_send";
		newSpan.innerHTML = time;
		newSubDiv0.appendChild(newSpan);
		var newImg = document.createElement("img");
		newImg.src = userImage;
		newImg.className = "rounded-circle user_img_msg";
		newSubDiv1.appendChild(newImg);
	}
	
	function viewReceivedMessage(content, time) {
		var messageList = document.getElementById("messageList");
		var newMessage = document.createElement("div");
		newMessage.className = "d-flex justify-content-start mb-4";
		messageList.appendChild(newMessage);
		var newSubDiv0 = document.createElement("div");
		newSubDiv0.className = "img_cont_msg";
		newMessage.appendChild(newSubDiv0);
		var newSubDiv1 = document.createElement("div");
		newSubDiv1.className = "msg_container";
		newSubDiv1.innerHTML = content;
		newMessage.appendChild(newSubDiv1);
		var newImg = document.createElement("img");
		for (var i = 0; i < contacts.length; i++){
		    if(contacts[i].id == activeChat)
		    	newImg.src = contacts[i].image;
		}
		newImg.className = "rounded-circle user_img_msg";
		newSubDiv0.appendChild(newImg);
		var newSpan = document.createElement("span");
		newSpan.className = "msg_time";
		newSpan.innerHTML = time;
		newSubDiv1.appendChild(newSpan);
	}

	function getMessage(id, content, time) {
		for (var i = 0; i < contacts.length; i++) {
			if (contacts[i].id == id) {
					contacts[i].messages.push(new Message(content, time.split(" ")[1], "RECEIVE"));
			}
		}
		
		if (id == activeChat) {
			viewReceivedMessage(content, time.split(" ")[1]);
		}
	}

	function postMessage(content) {
		document.getElementById("textarea").value = "";
		var now = new Date();
 		var year = "" + now.getFullYear();
  		var month = "" + (now.getMonth() + 1); if (month.length == 1) { month = "0" + month; };
  		var day = "" + now.getDate(); if (day.length == 1) { day = "0" + day; };
  		var hour = "" + now.getHours(); if (hour.length == 1) { hour = "0" + hour; };
  		var minute = "" + now.getMinutes(); if (minute.length == 1) { minute = "0" + minute; };
  		var second = "" + now.getSeconds(); if (second.length == 1) { second = "0" + second; };
  		var date = year + "-" + month + "-" + day + " " + hour + ":" + minute + ":" + second;
		for(var i = 0; i < contacts.length; i++) {
		    if(contacts[i].id == activeChat)
		    	contacts[i].messages.push(new Message(content, date.split(" ")[1], "SEND"));
		}
		viewSentMessage(content, date.split(" ")[1]);
		for(var i = 0; i < contacts.length; i++) {
			if(contacts[i].id == activeChat) { 
				webSocket.send("{'id':'2', 'message':'" + content + "', 'from':'" + username + "', 'to':'" + contacts[i].name + "', 'date':'" + date + "'}");
			}
		}              
	}

	function loadContact(name, image, online, id) {
		//webSocket.send("{'id':'1', 'username':'" + username + "', 'password':'" + password + "'}");
		contactCard = document.getElementById("contactCard");
		contactCard.style.display = "";
		dynamicImg = document.getElementById("dynamicImg");
		dynamicImg.src = image;
		dynamicName = document.getElementById("dynamicName");
		dynamicName.innerHTML = name;
		/*dynamicOnline = document.getElementById("dynamicOnline");
		if(online)
			dynamicOnline.className = "online_icon";
		else
			dynamicOnline.className = "online_icon offline";*/
		if(activeChat != 0)
		    document.getElementById(activeChat).className = "";
		document.getElementById(id).className = "active";
		var messageList = document.getElementById("messageList");
		if (id != activeChat) {
			activeChat = id;
			messageList.innerHTML = "";
			loadMessages(id);
		}
		activeChat = id;
	}

	function addContact(image, name, id, online, lastLog) {
		var contactsList = document.getElementById("contactsList");
		var newContact = document.createElement("li");
		newContact.id = id;
		newContact.onclick = function() { loadContact(name, image, online, id);  newContact.className = "active"; document.getElementById("addFriendText").style.display = "none"; document.getElementById("addFriendButton").style.display = "none"; document.getElementById("messagesPanel").style.display = ""; document.getElementById("messageList").style.display = ""; document.getElementById("messagesFooter").style.display = "";};
		contactsList.appendChild(newContact);
		var newDiv = document.createElement("div");
		newDiv.className = "d-flex bd-highlight";
		newContact.appendChild(newDiv);
		var newSubDiv0 = document.createElement("div");
		newSubDiv0.className = "img_cont";
		newDiv.appendChild(newSubDiv0);
		var newSubDiv1 = document.createElement("div");
		newSubDiv1.className = "user_info";
		newDiv.appendChild(newSubDiv1);
		var newImg = document.createElement("img");
		newImg.src = image;
		newImg.className = "rounded-circle user_img";
		newSubDiv0.appendChild(newImg);
		/*newSpan0 = document.createElement("span");
		if (online == true)
			newSpan0.className = "online_icon";
		else
			newSpan0.className = "online_icon offline"
		newSubDiv0.appendChild(newSpan0);*/
		var newSpan1 = document.createElement("span");
		newSpan1.innerHTML = name;
		newSubDiv1.appendChild(newSpan1);
		/*var newP = document.createElement("p");
		if (online == true)
			newP.innerHTML = "online";
		else
			newP.innerHTML = "Last log: " + lastLog;
		newSubDiv1.appendChild(newP);*/
	}

	function addAddFriend() {
		var contactsList = document.getElementById("contactsList");
		var newContact = document.createElement("li");
		newContact.onclick = function() {document.getElementById("contactCard").style.display = ""; document.getElementById("addFriendText").style.display = ""; document.getElementById("addFriendButton").style.display = ""; document.getElementById("messagesPanel").style.display = "none"; document.getElementById("messageList").style.display = "none"; document.getElementById("messagesFooter").style.display = "none";};
		contactsList.appendChild(newContact);
		var newDiv = document.createElement("div");
		newDiv.className = "d-flex bd-highlight";
		newContact.appendChild(newDiv);
		var newSubDiv0 = document.createElement("div");
		newSubDiv0.className = "img_cont";
		newDiv.appendChild(newSubDiv0);
		var newSubDiv1 = document.createElement("div");
		newSubDiv1.className = "user_info";
		newDiv.appendChild(newSubDiv1);
		var newImg = document.createElement("img");
		newImg.src = "addFriend.png";
		newImg.className = "rounded-circle add_img";
		newSubDiv0.appendChild(newImg);
		var newSpan1 = document.createElement("span");
		newSpan1.innerHTML = "Add Friend";
		newSubDiv1.appendChild(newSpan1);
		var newHr = document.createElement("hr");
		newHr.className = "addFriendHr";
		newContact.appendChild(newHr);
	}
	
	//setupWebSocket();

	function main() {
	
	var contactCard = document.getElementById("contactCard");
	contactCard.style.display = "none";
	addAddFriend();	
	//var newContact = new Contact("https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Ftse4.mm.bing.net%2Fth%3Fid%3DOIP._9SsO9_KzjYz0lPYS6XPOAHaHa%26pid%3DApi&f=1", "ddg", 1, true, "online", []);
	//var newContact2 = new Contact("https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Fi.ytimg.com%2Fvi%2Fyt0CE-bN--g%2Fhqdefault.jpg&f=1&nofb=1", "google", 2, true, "online", []);
	//contacts.push(newContact, newContact2);

	$.getJSON("getData.php", getData);
	$.getJSON("loadContacts.php", loadContacts);
	$.getJSON("loadFriendshipRequests.php", loadFriendshipRequests);
	//setupWebSocket();

	//loadMessagesFromDatabase();

	//getMessage(1, "Henlo", "*time*");
	//getMessage(2, "roflmao", "*time2*");
	//postMessage("akdakdsoad", "taim");

	//for (var i = 0; i < contacts.length; i++) {
	//	addContact(contacts[i].image, contacts[i].name, contacts[i].id, contacts[i].online, contacts[i].lastLog);
	//}
	//addFriendshipRequest("firefox", "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Fupload.wikimedia.org%2Fwikipedia%2Fcommons%2Fthumb%2F6%2F67%2FFirefox_Logo%2C_2017.svg%2F1200px-Firefox_Logo%2C_2017.svg.png&f=1&nofb=1");
}
