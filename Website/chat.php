<link href="//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/css/bootstrap.min.css" rel="stylesheet" id="bootstrap-css">
<script src="//maxcdn.bootstrapcdn.com/bootstrap/4.1.1/js/bootstrap.min.js"></script>
<script src="//cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>
<!------ Include the above in your HEAD tag ---------->

<!DOCTYPE html>
<html>
	<head>
		<title>Chat</title>
		<link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.1.3/css/bootstrap.min.css" integrity="sha384-MCw98/SFnGE8fJT3GXwEOngsV7Zt27NXFoaoApmYm81iuXoPkFOJwJ8ERdknLPMO" crossorigin="anonymous">
		<link rel="stylesheet" href="https://use.fontawesome.com/releases/v5.5.0/css/all.css" integrity="sha384-B4dIYHKNBt8Bc12p+WXckhzcICo0wtJAoU8YZTY5qE0Id1GSseTk6S+L3BlXeVIU" crossorigin="anonymous">
		<script src="https://ajax.googleapis.com/ajax/libs/jquery/3.3.1/jquery.min.js"></script>
		<link rel="stylesheet" type="text/css" href="https://cdnjs.cloudflare.com/ajax/libs/malihu-custom-scrollbar-plugin/3.1.5/jquery.mCustomScrollbar.min.css">
		<script type="text/javascript" src="https://cdnjs.cloudflare.com/ajax/libs/malihu-custom-scrollbar-plugin/3.1.5/jquery.mCustomScrollbar.min.js"></script>
	</head>
	<!--Coded With Love By Mutiullah Samim-->
	<body>
		<div class="container-fluid h-100">
			<div class="row justify-content-center h-100">
				<div class="col-md-4 col-xl-3 chat"><div class="card mb-sm-3 mb-md-0 contacts_card">
					<div class="card-header">
						<div class="input-group">
							<input type="text" placeholder="Search..." name="" class="form-control search">
							<div class="input-group-prepend">
								<span class="input-group-text search_btn"><i class="fas fa-search"></i></span>
							</div>
						</div>
					</div>
					<div class="card-body contacts_body">
						<ui class="contacts" id="contactsList"></ui>
					</div>
					<div class="card-footer"></div>
				</div></div>
				<div class="col-md-8 col-xl-6 chat">
					<div class="card">
						<div class="card-header msg_head">
							<div class="d-flex bd-highlight">
								<div class="img_cont">
									<img id="dynamicImg" src="" class="rounded-circle user_img">
									<span class="online_icon"></span>
								</div>
								<div class="user_info">
									<span id="dynamicName"></span>
								</div>
								<div class="video_cam">
									<span><i class="fas fa-video"></i></span>
									<span><i class="fas fa-phone"></i></span>
								</div>
							</div>
							<span id="action_menu_btn"><i class="fas fa-ellipsis-v"></i></span>
							<div class="action_menu">
								<ul>
									<li><i class="fas fa-user-circle"></i> View profile</li>
									<li><i class="fas fa-users"></i> Add to close friends</li>
									<li><i class="fas fa-plus"></i> Add to group</li>
									<li><i class="fas fa-ban"></i> Block</li>
								</ul>
							</div>
						</div>
						<div class="card-body msg_card_body" id="messageList"></div>
						<div class="card-footer">
							<div class="input-group">
								<div class="input-group-append">
									<span class="input-group-text attach_btn"><i class="fas fa-paperclip"></i></span>
								</div>
								<textarea name="" class="form-control type_msg" placeholder="Type your message..."></textarea>
								<div class="input-group-append">
									<span class="input-group-text send_btn"><i class="fas fa-location-arrow"></i></span>
								</div>
							</div>
						</div>
					</div>
				</div>
			</div>
		</div>
	</body>
</html>
<style>
    	body,html{
			height: 100%;
			margin: 0;
			background: #7F7FD5;
	       background: -webkit-linear-gradient(to right, #91EAE4, #86A8E7, #7F7FD5);
	        background: linear-gradient(to right, #91EAE4, #86A8E7, #7F7FD5);
		}

		.chat{
			margin-top: auto;
			margin-bottom: auto;
		}
		.card{
			height: 500px;
			border-radius: 15px !important;
			background-color: rgba(0,0,0,0.4) !important;
		}
		.contacts_body{
			padding:  0.75rem 0 !important;
			overflow-y: auto;
			white-space: nowrap;
		}
		.msg_card_body{
			overflow-y: auto;
		}
		.card-header{
			border-radius: 15px 15px 0 0 !important;
			border-bottom: 0 !important;
		}
	 .card-footer{
		border-radius: 0 0 15px 15px !important;
			border-top: 0 !important;
	}
		.container{
			align-content: center;
		}
		.search{
			border-radius: 15px 0 0 15px !important;
			background-color: rgba(0,0,0,0.3) !important;
			border:0 !important;
			color:white !important;
		}
		.search:focus{
		     box-shadow:none !important;
           outline:0px !important;
		}
		.type_msg{
			background-color: rgba(0,0,0,0.3) !important;
			border:0 !important;
			color:white !important;
			height: 60px !important;
			overflow-y: auto;
		}
			.type_msg:focus{
		     box-shadow:none !important;
           outline:0px !important;
		}
		.attach_btn{
	border-radius: 15px 0 0 15px !important;
	background-color: rgba(0,0,0,0.3) !important;
			border:0 !important;
			color: white !important;
			cursor: pointer;
		}
		.send_btn{
	border-radius: 0 15px 15px 0 !important;
	background-color: rgba(0,0,0,0.3) !important;
			border:0 !important;
			color: white !important;
			cursor: pointer;
		}
		.search_btn{
			border-radius: 0 15px 15px 0 !important;
			background-color: rgba(0,0,0,0.3) !important;
			border:0 !important;
			color: white !important;
			cursor: pointer;
		}
		.contacts{
			list-style: none;
			padding: 0;
		}
		.contacts li{
			width: 100% !important;
			padding: 5px 10px;
			margin-bottom: 15px !important;
		}
	.active{
			background-color: rgba(0,0,0,0.3);
	}
		.user_img{
			height: 70px;
			width: 70px;
			border:1.5px solid #f5f6fa;
		
		}
		.user_img_msg{
			height: 40px;
			width: 40px;
			border:1.5px solid #f5f6fa;
		
		}
	.img_cont{
			position: relative;
			height: 70px;
			width: 70px;
	}
	.img_cont_msg{
			height: 40px;
			width: 40px;
	}
	.online_icon{
		position: absolute;
		height: 15px;
		width:15px;
		background-color: #4cd137;
		border-radius: 50%;
		bottom: 0.2em;
		right: 0.4em;
		border:1.5px solid white;
	}
	.offline{
		background-color: #c23616 !important;
	}
	.user_info{
		margin-top: auto;
		margin-bottom: auto;
		margin-left: 15px;
	}
	.user_info span{
		font-size: 20px;
		color: white;
	}
	.user_info p{
	font-size: 10px;
	color: rgba(255,255,255,0.6);
	}
	.video_cam{
		margin-left: 50px;
		margin-top: 5px;
	}
	.video_cam span{
		color: white;
		font-size: 20px;
		cursor: pointer;
		margin-right: 20px;
	}
	.msg_container{
		margin-top: auto;
		margin-bottom: auto;
		margin-left: 10px;
		border-radius: 25px;
		background-color: #82ccdd;
		padding: 10px;
		position: relative;
	}
	.msg_container_send{
		margin-top: auto;
		margin-bottom: auto;
		margin-right: 10px;
		border-radius: 25px;
		background-color: #78e08f;
		padding: 10px;
		position: relative;
	}
	.msg_time{
		position: absolute;
		left: 0;
		bottom: -15px;
		color: rgba(255,255,255,0.5);
		font-size: 10px;
	}
	.msg_time_send{
		position: absolute;
		right:0;
		bottom: -15px;
		color: rgba(255,255,255,0.5);
		font-size: 10px;
	}
	.msg_head{
		position: relative;
	}
	#action_menu_btn{
		position: absolute;
		right: 10px;
		top: 10px;
		color: white;
		cursor: pointer;
		font-size: 20px;
	}
	.action_menu{
		z-index: 1;
		position: absolute;
		padding: 15px 0;
		background-color: rgba(0,0,0,0.5);
		color: white;
		border-radius: 15px;
		top: 30px;
		right: 15px;
		display: none;
	}
	.action_menu ul{
		list-style: none;
		padding: 0;
	margin: 0;
	}
	.action_menu ul li{
		width: 100%;
		padding: 10px 15px;
		margin-bottom: 5px;
	}
	.action_menu ul li i{
		padding-right: 10px;
	
	}
	.action_menu ul li:hover{
		cursor: pointer;
		background-color: rgba(0,0,0,0.2);
	}
	@media(max-width: 576px){
	.contacts_card{
		margin-bottom: 15px !important;
	}
	}
</style>
<script>

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
	var activeChat = 1;
	var userID = 6;
	var userImage;

	function loadMessages(id) {
		for (var i = 0; i < contacts[id].messages.length; i++) {
			if (contacts[id].messages[i].mode == "SEND")
				viewSentMessage(contacts[id].messages[i].content, contacts[id].messages.time);
			else if (contacts[id].messages[i].mode == "RECEIVE")
				viewReceivedMessage(contacts[id].messages[i].content, contacts[id].messages.time);
		}
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
		newImg.src = contacts[activeChat].image;
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
					contacts[i].messages.push(new Message(content, time, "RECEIVE"));
			}
		}
		
		if (id == activeChat) {
			viewReceivedMessage(content, time);
		}
	}

	function postMessage(content, time) {
		contacts[activeChat].messages.push(new Message(content, time, "SEND"));
		viewSentMessage(content, time);
	}

	function loadContact(name, image, online, id) {
		dynamicImg = document.getElementById("dynamicImg");
		dynamicImg.src = image;
		dynamicName = document.getElementById("dynamicName");
		dynamicName.innerHTML = name;
		document.getElementById(activeChat).className = "";
		document.getElementById(id).className = "active";
		var messageList = document.getElementById("messageList");
		if (id != activeChat) {
			messageList.innerHTML = "";
			loadMessages(id);
		}
		activeChat = id;
	}

	function addContact(image, name, id, online, lastLog) {
		var contactsList = document.getElementById("contactsList");
		var newContact = document.createElement("li");
		newContact.id = id;
		newContact.onclick = function() { loadContact(name, image, online, id);  newContact.className = "active";};
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
		newSpan0 = document.createElement("span");
		if (online == true)
			newSpan0.className = "online_icon";
		else
			newSpan0.className = "online_icon offline"
		newSubDiv0.appendChild(newSpan0);
		var newSpan1 = document.createElement("span");
		newSpan1.innerHTML = name;
		newSubDiv1.appendChild(newSpan1);
		var newP = document.createElement("p");
		if (online == true)
			newP.innerHTML = "online";
		else
			newP.innerHTML = "Last log: " + lastLog;
		newSubDiv1.appendChild(newP);
	}

	var newContact = new Contact("https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Ftse4.mm.bing.net%2Fth%3Fid%3DOIP._9SsO9_KzjYz0lPYS6XPOAHaHa%26pid%3DApi&f=1", "ddg", 0, true, "online", []);
	var newContact2 = new Contact("https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Fi.ytimg.com%2Fvi%2Fyt0CE-bN--g%2Fhqdefault.jpg&f=1&nofb=1", "google", 1, true, "online", []);
	contacts.push(newContact, newContact2);

	getMessage(0, "Henlo", "*time*");
	getMessage(1, "roflmao", "*time2*");
	postMessage("akdakdsoad", "taim");

	for (var i = 0; i < contacts.length; i++) {
		addContact(contacts[i].image, contacts[i].name, contacts[i].id, contacts[i].online, contacts[i].lastLog);
	}
</script>
