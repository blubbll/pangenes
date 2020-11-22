# pangenes

since pangenesisgame.net is semi-ded, let's crack the protocol (kind of)!

(the username is stored in /gamedir/config.txt in <username>XXX</username>)

tools i used:

web debugging
hex editor (lol)



let formData = new FormData();
formData.append('name', 'Blubbll');
formData.append('pass', '');

fetch("https://pangenesisgame.com/login/login.php", {method: "POST", body: FormData}).then(res => res.text()).then(text => console.log(text))

no,0 