# pangenes

since pangenesisgame.net is semi-ded, let's crack the protocol (kind of)!

(the username is stored in /gamedir/config.txt in <username>XXX</username>)
tools i used:

- web debugging
- hex editor (lol)

tried to login to the webserver
let formData = new FormData();
formData.append('name', 'Blubbll');
formData.append('pass', '');

fetch("https://pangenesisgame.com/login/login.php", {method: "POST", body: FormData}).then(res => res.text()).then(text => console.log(text))

but it says
no,0 

current stati:
-  no,0 = could not log in
-  no,1 = invalid username
-  no,2 = your user account does nto have permission to log in
-  no,3 = A New version is available. Update now (this is interesting lol, clicking ok removes your username from the config kek)
-  no,4 = Too many bad logins. Please visit bensgames.net/alpha (the fuq)
-  no, 5+ : same as 0

authserver offline?
- you can enforce playing offline by moving to the offset aHudnologin1 instead of aHudnologin2 and clicking "yes"
- multiplayer wont be possible here