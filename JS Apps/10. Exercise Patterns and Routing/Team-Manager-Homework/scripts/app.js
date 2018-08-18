$(() => {
    const app = Sammy('#main', function () {
        this.use('Handlebars', 'hbs');

        this.get('index.html', pageController.displayHome);
        this.get('#/home', pageController.displayHome);

        this.get('#/about', pageController.displayAbout);

        this.get('#/login', pageController.getLogin);
        this.post('#/login', pageController.postLogin);

        this.get('#/logout', pageController.logout);

        this.get('#/register', pageController.getRegister);
        this.post('#/register', pageController.postRegister);

        this.get('#/catalog', pageController.getCatalog);

        this.get('#/create', pageController.getCreateTeam);
        this.post('#/create', pageController.postCreateTeam);

        this.get('#/catalog/:id', pageController.getTeamDetails);

        this.get('#/join/:id', pageController.joinTeam);
        this.get('#/leave', pageController.leaveTeam);

        this.get('#/edit/:id', pageController.getTeamEdit);
        this.post('#/edit/:id', pageController.postTeamEdit);
    });

    app.run();
});