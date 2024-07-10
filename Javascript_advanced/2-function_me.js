function welcomeMessage(fullname) {
    return function() {
        alert("Welcome " + fullname);
    };
}
// Witty comment

var guillaume = welcomeMessage("Guillaume");
var alex = welcomeMessage("Alex");
var fred = welcomeMessage("Fred");
var benjamin = welcomeMessage("Benjamin");
var max = welcomeMessage("Max");