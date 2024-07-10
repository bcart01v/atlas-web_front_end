function changeMode(size, weight, transform, background, color) {
    return function () {
        document.body.style.fontSize = size + "px";
        document.body.style.fontWeight = weight;
        document.body.style.textTransform = transform;
        document.body.style.backgroundColor = background;
        document.body.style.color = color;
    };
}

// I decided to try to recreate the page as it's displayed on the intranet. 
// This will help me understand javascript more, and also help with
// my job when it comes to understanding the Javascript that's currently written.

function main() {
    // Our Options
    var spooky = changeMode(9, "bold", "uppercase", "pink", "green");
    var darkMode = changeMode(12, "bold", "capitalize", "black", "white");
    var screamMode = changeMode(12, "normal", "lowercase", "white", "black");

    var h1 = document.createElement("h1");
    h1.innerText = "You're browsing as a guest";
    document.body.appendChild(h1);

    var h3 = document.createElement("h3");
    h3.innerText = "Pages you view in this window won't appear in the browser history and they won't leave other traces, like cookies, on the computer after you close all open guest windows. Any files you download will be preserved, however.";
    document.body.appendChild(h3);

    var link = document.createElement("a");
    link.href = "https://youtu.be/dQw4w9WgXcQ?si=YZj5r2QVWn1BkhUS";
    link.innerText = "Learn More";
    link.target = "_blank"; // Don't navigate away, stay here! Open in new tab.
    document.body.appendChild(link);

    var leftAlignedH3 = document.createElement("h3");
    leftAlignedH3.innerText = "Welcome Holberton!";
    leftAlignedH3.style.textAlign = "left";
    document.body.appendChild(leftAlignedH3);

    var spookyButton = document.createElement("button");
    spookyButton.innerText = "Spooky";
    document.body.appendChild(spookyButton);
    spookyButton.addEventListener("click", spooky);

    var darkModeButton = document.createElement("button");
    darkModeButton.innerText = "Dark mode";
    document.body.appendChild(darkModeButton);
    darkModeButton.addEventListener("click", darkMode);

    var screamModeButton = document.createElement("button");
    screamModeButton.innerText = "Scream mode";
    document.body.appendChild(screamModeButton);
    screamModeButton.addEventListener("click", screamMode);
}
