/*! normalize.css v8.0.1 | MIT License | github.com/necolas/normalize.css */

*,
*:before,
*:after {
    box-sizing: border-box;
}

html {
    line-height: 1.15;
    -webkit-text-size-adjust: 100%
}

body {
    margin: 0
}

main {
    display: block
}

h1 {
    font-size: 2em;
    margin: .67em 0
}

hr {
    box-sizing: content-box;
    height: 0;
    overflow: visible
}

pre {
    font-family: monospace, monospace;
    font-size: 1em
}

a {
    background-color: transparent
}

abbr[title] {
    border-bottom: none;
    text-decoration: underline;
    text-decoration: underline dotted
}

b,
strong {
    font-weight: bolder
}

code,
kbd,
samp {
    font-family: monospace, monospace;
    font-size: 1em
}

small {
    font-size: 80%
}

sub,
sup {
    font-size: 75%;
    line-height: 0;
    position: relative;
    vertical-align: baseline
}

sub {
    bottom: -.25em
}

sup {
    top: -.5em
}

img {
    border-style: none
}

button,
input,
optgroup,
select,
textarea {
    font-family: inherit;
    font-size: 100%;
    line-height: 1.15;
    margin: 0
}

button,
input {
    overflow: visible
}

button,
select {
    text-transform: none
}

[type=button],
[type=reset],
[type=submit],
button {
    -webkit-appearance: button
}

[type=button]::-moz-focus-inner,
[type=reset]::-moz-focus-inner,
[type=submit]::-moz-focus-inner,
button::-moz-focus-inner {
    border-style: none;
    padding: 0
}

[type=button]:-moz-focusring,
[type=reset]:-moz-focusring,
[type=submit]:-moz-focusring,
button:-moz-focusring {
    outline: 1px dotted ButtonText
}

fieldset {
    padding: .35em .75em .625em
}

legend {
    box-sizing: border-box;
    color: inherit;
    display: table;
    max-width: 100%;
    padding: 0;
    white-space: normal
}

progress {
    vertical-align: baseline
}

textarea {
    overflow: auto
}

[type=checkbox],
[type=radio] {
    box-sizing: border-box;
    padding: 0
}

[type=number]::-webkit-inner-spin-button,
[type=number]::-webkit-outer-spin-button {
    height: auto
}

[type=search] {
    -webkit-appearance: textfield;
    outline-offset: -2px
}

[type=search]::-webkit-search-decoration {
    -webkit-appearance: none
}

::-webkit-file-upload-button {
    -webkit-appearance: button;
    font: inherit
}

details {
    display: block
}

summary {
    display: list-item
}

template {
    display: none
}

[hidden] {
    display: none
}

/*# sourceMappingURL=normalize.min.css.map */

:root {
    /* Colors */
    --color-primary: #d73953;
    --color-black: #090909;
    --color-white: #ffffff;
    --color-light-grey: #f3f3f3;
    --color-dark-grey: #353535;

    /* Font */
    --text-color: var(--color-black);
    --font-family-base: "Open Sans", "Helvetica Neue", Helvetica, Arial, sans-serif;
    --font-family-title: "Raleway", "Helvetica Neue", Helvetica, Arial, sans-serif;
    --font-size-small: 1.2rem;
    --font-size-medium: 1.6rem;
    --font-size-large: 1.8rem;
    --font-size-x-large: 2.3rem;
    --font-size-xx-large: 4.8rem;
    --font-weight-regular: 400;
    --font-weight-bold: 700;

    /* Line */
    --line-height-small: 1.2;
    --line-height-base: 1.5;
    --line-height-big: 1.8;

    /* Section */
    --section-header-align: center;
    --section-tagline-transform: uppercase;
    --section-title-margin: 0;
    --section-title-color: var(--color-black);
    --section-padding: 5rem 0;
    --section-header-padding: 0 0 3rem;
    --section-body-padding: 0 0 3rem;
    --section-footer-padding: 3rem 0 0;
    --section-footer-align: center;
    --footer-padding: 5rem 0 1rem;
    --section-tagline-margin: 0;

    /* Navigation */
    --nav-item-font-family: var(--font-family-title);
    --nav-item-font-weight: var(--font-weight-bold);
    --nav-item-font-size: var(--font-size-medium);
    --nav-item-letter-spacing: 0.04rem;
    --nav-item-display: inline-block;
    --nav-item-margin: 0 0 3rem;
    --nav-item-link-hover: var(--color-primary);

    /* Button */
    --button-display: inline-block;
    --button-padding: 1.5rem 3rem;
    --button-border: 0.2rem solid var(--color-primary);
    --button-color: var(--color-black);
    --button-text-decoration: none;
    --button-font-size: var(--font-size-large);
    --button-hover-color: var(--color-white);
    --button-hover-text-decoration: none;
    --button-hover-background: var(--color-primary);
}

html {
    scroll-behavior: smooth;
    font-size: 62.5%;
}

body,
a {
    color: var(--text-color);
    text-decoration: none;
}

body {
    font-family: var(--font-family-base);
    font-size: var(--font-size-medium);
    font-weight: var(--font-weight-regular);
    line-height: var(--line-height-base);
}

h1,
h2,
h3,
h4,
h5,
h6 {
    font-family: var(--font-family-title);
    font-weight: var(--font-weight-bold);
}

.visually-hidden {
    display: none;
}

.card-category {
    color: var(--text-primary);
}

.card-services .card-title {
    margin: 0;
}

.card-services a {
    display: block;
    padding: 2rem;
    background-color: var(--color-light-grey);
}

.card-services a:hover {
    color: var(--color-white);
    background-color: var(--color-primary);
    text-decoration: none;
}

.section {
    padding: var(--section-padding);
}

.section-header {
    padding: var(--section-header-padding);
    text-align: var(--section-header-align);
}

.section-body {
    padding: var(--section-body-padding);
}

.section-footer {
    padding: var(--section-footer-padding);
    text-align: var(--section-footer-align);
}

.section-title {
    font-family: var(--font-family-title);
    font-size: var(--font-size-xx-large);
    font-weight: var(--font-weight-bold);
    margin: var(--section-title-margin);
    color: var(--section-title-color);
}

.section-tagline {
    color: var(--text-primary);
    font-family: var(--font-family-title);
    text-transform: var(--section-tagline-transform);
    font-weight: var(--font-weight-bold);
    margin: var(--section-tagline-margin);
}

.container {
    width: 960px;
    margin-left: auto;
    margin-right: auto;
}

a:link {
    color: var(--text-color);
    text-decoration: none;
}

a:visited {
    font-style: italic;
}

a:hover {
    text-decoration: underline;
}

a:active {
    background-color: var(--color-light-grey);
}

.button {
    display: var(--button-display);
    padding: var(--button-padding);
    border: var(--button-border);
    font-size: var(--button-font-size);
    color: var(--button-color);
    text-decoration: var(--button-text-decoration);
}

.button:hover {
    color: var(--button-hover-color);
    text-decoration: var(--button-hover-text-decoration);
    background-color: var(--button-hover-background);
}

.navbar-menu {
    float: right;
}

.nav {
    margin: 0;
    padding: 0;
    list-style: none;
    text-align: center;
}

.nav .nav-item {
    font-family: var(--nav-item-font-family);
    font-weight: var(--nav-item-font-weight);
    font-size: var(--nav-item-font-size);
    letter-spacing: var(--nav-item-letter-spacing);
    display: var(--nav-item-display);
    margin: var(--nav-item-margin);
}

.nav .nav-link {
    display: block;
    padding: 0.5rem 1rem;
}

.nav .nav-link:hover {
    color: var(--nav-item-link-hover);
}

ul.row {
    margin: 0;
    padding: 0;
    list-style-type: none;
}

.row::after {
    content: "";
    display: table;
    clear: both;
}

[data-section-theme="dark"] {
    --text-color: var(--color-white);
    --section-title-color: var(--color-white);
    --button-color: var(--color-white);
    background-color: var(--color-black);
}

[class^="col-"] {
    float: left;
    padding: 0.5rem;
}

.col-1-3 {
    width: 33.33%;
}

.col-1-2 {
    width: 50%;
}

.footer {
    padding: var(--footer-padding);
}

.footer-address {
    color: var(--text-color);
}

.social-link {
    display: block;
}

.social-link>svg {
    fill: var(--text-color);
}

.footer-copyright {
    margin: 0;
    font-size: var(--font-size-small);
    color: var(--text-color);
}

.footer ul {
    text-align: right;
}