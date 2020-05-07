function main() {

	var newContact = new Contact("https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Ftse4.mm.bing.net%2Fth%3Fid%3DOIP._9SsO9_KzjYz0lPYS6XPOAHaHa%26pid%3DApi&f=1", "ddg", 1, true, "online", []);
	var newContact2 = new Contact("https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Fi.ytimg.com%2Fvi%2Fyt0CE-bN--g%2Fhqdefault.jpg&f=1&nofb=1", "google", 2, true, "online", []);

	contacts.push(newContact, newContact2);
	
	getMessage(1, "Henlo", "*time*");
	getMessage(2, "roflmao", "*time2*");
	postMessage("akdakdsoad", "taim");

	for (var i = 0; i < contacts.length; i++) {
		addContact(contacts[i].image, contacts[i].name, contacts[i].id, contacts[i].online, contacts[i].lastLog);
	}

	addFriendshipRequest("q", "q");

	//setupWebSocket();
	
	//$.getJSON("getData.php", getData);
	//$.getJSON("loadContacts.php", loadContacts);

	//loadMessagesFromDatabase();
}
