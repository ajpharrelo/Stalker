'use strict';
var debug = require('debug')('my express app');
var express = require('express');
var path = require('path');
var logger = require('morgan');
var bodyParser = require('body-parser');
var handlebars = require('express-handlebars')

var routes = require('./routes/index');
var users = require('./routes/users');

var app = express();

// view engine setup
app.engine('hbs', handlebars.engine({ defaultLayout: '_main', extname: '.hbs', layoutsDir:"views/layouts" }))
app.set('views', path.join(__dirname, 'views'));
app.set('view engine', 'hbs');


app.use(logger('dev'));
app.use(bodyParser.json());
app.use(bodyParser.urlencoded({ extended: false }));


// Static files
app.use(express.static(path.join(__dirname, 'public')));
app.use(express.static('./node_modules/bulma/'))
app.use(express.static('./node_modules/bootstrap-icons/'))


app.use('/', routes);
app.use('/users', users);

app.set('port', process.env.PORT || 3000);

var server = app.listen(app.get('port'), function () {
    debug('Express server listening on port ' + server.address().port);
});
