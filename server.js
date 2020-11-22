// server.js
// where your node app starts

// we've started you off with Express (https://expressjs.com/)
// but feel free to use whatever libraries or frameworks you'd like through `package.json`.
const express = require("express");
const app = express();

// our default array of dreams
const dreams = [
  "Find and count some sheep",
  "Climb a really tall mountain",
  "Wash the dishes"
];

app.use(express.json());

app.use(express.urlencoded({ extended: false })); //<--

// make all the files in 'public' available
// https://expressjs.com/en/starter/static-files.html
app.use(express.static("public"));

// https://expressjs.com/en/starter/basic-routing.html
app.get("/", (request, response) => {
  response.sendFile(__dirname + "/views/index.html");
});

// https://expressjs.com/en/starter/basic-routing.html
app.use("/*", (request, response, next) => {
  console.log(request.originalUrl);
  next();
});

// https://expressjs.com/en/starter/basic-routing.html
app.get("/login/servers.php", (request, response) => {
  console.log(1);
  response.sendFile(__dirname + "/views/index.html");
});

// https://expressjs.com/en/starter/basic-routing.html
app.post("/login/login.php", (req, res) => {
  const Login = {user: req.body.user, pass: req.body.pass, ver: req.body.ver};
  console.log(`${Login.ver}Login attempt from [${Login.user}] with pass [${Login.pass}]!`);

  /*
  no,0 = could not log in
  no,1 = invalid username
  no,2 = your user account does nto have permission to log in
  */
  
  res.write("no,2");
  res.end();
});

// https://expressjs.com/en/starter/basic-routing.html
app.post("/login/keepalive.php", (req, res) => {
  const Login = {user: req.body.user, pass: req.body.pass};
  console.log(`Login attempt from [${Login.user}] with pass [${Login.pass}]!`);
  
  res.status(200);
});


// https://expressjs.com/en/starter/basic-routing.html
app.get("/login/servers.php*/", (request, response) => {
  console.log(1);
  response.sendFile(__dirname + "/views/index.html");
});

// listen for requests :)
const listener = app.listen(process.env.PORT, () => {
  console.log("Your app is listening on port " + listener.address().port);
});
