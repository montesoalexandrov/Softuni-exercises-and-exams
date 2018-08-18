$(() => {
    const templates = {};
    const context = {
        cats: []
    };

    context.cats = window.cats;

    const catsList = $('#allCats');

    loadTemplates();

    async function loadTemplates() {
        const [catsList, cat] =
            await Promise.all([
                $.get('./templates/cats-list.hbs'),
                $.get('./templates/cat.hbs'),
            ]);

        Handlebars.registerPartial('cat', cat);
        templates.catsList = Handlebars.compile(catsList);

        renderCatTemplate();
    }

    function renderCatTemplate() {
       catsList.html(templates.catsList(context));

       attachEventHandlers();
    }

    function attachEventHandlers() {

        catsList.children().find('#infoBtn').click( (e) => {
            $(e.target)
                .closest('.card-block')
                .find('.status-info')
                .toggle();
        });
    }
});
