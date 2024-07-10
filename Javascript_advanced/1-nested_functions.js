var globalVariable = "Welcome";

function outer() {
    alert (globalVariable);
    var course = "Holberton"; // Should be ATLAS!!!

    function inner() {
        alert (globalVariable + " " + course);
        var exclamation = "!";
        // A dream within a dream within a dream?!
        function inception() { 
            alert(globalVariable + " " + course + exclamation);
        }
        inception();
    }
    inner();
}
outer();