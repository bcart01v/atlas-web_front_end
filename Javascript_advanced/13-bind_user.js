const user = {
    hobby: "Calligraphy",
    favoriteSport: "Hocky",
    astrologicalSign: "Aries",
    firstName: "Buillaume",
    lastName: "Netherlands",
    occupation: "Engineer"
};

function logWelcomeUser(welcomeString) {
    console.log(`${welcomeString}, ${this.firstName}. Your occupation is: ${this.occupation}`);
}

const bindLogWelcomeUser = logWelcomeUser.bind(user);
