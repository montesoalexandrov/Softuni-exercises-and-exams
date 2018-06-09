const Article = require('../models').Article;

module.exports = {
    index: (req, res) => {
        Article.findAll({ limit: 10}).then(articles=>{
            res.render('home/index',{articles: articles});
        })
    }
};