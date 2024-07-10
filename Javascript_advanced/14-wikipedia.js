function createElement(data) {
    const paragraph = document.createElement('p');
    paragraph.textContent = data;
    document.body.appendChild(paragraph);
}

function queryWikipedia(callback) {
    const xhr = new XMLHttpRequest();
    const url = 'https://en.wikipedia.org/w/api.php?format=json&action=query&prop=extracts&exintro&explaintext&redirects=1&titles=Stack%20Overflow&origin=*';

    xhr.onload = function() {
        if (xhr.status >= 200 && xhr.status < 300) {
            const response = JSON.parse(xhr.responseText);
            const pages = response.query.pages;
            const pageId = Object.keys(pages)[0];
            const extract = pages[pageId].extract;
            callback(extract);
        } else {
            console.error('Request failed');
        }
    };

    xhr.open('GET', url);
    xhr.send();
}

queryWikipedia(createElement);
