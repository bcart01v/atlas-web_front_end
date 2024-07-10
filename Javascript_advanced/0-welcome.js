// A Surprise to be sure, but a welcome one.
function welcome(firstname, lastname) {
    var fullname = firstname + " "  + lastname;

    function displayFullName() {
        alert("Welcome " + fullname + "!");
    }

    displayFullName();
}