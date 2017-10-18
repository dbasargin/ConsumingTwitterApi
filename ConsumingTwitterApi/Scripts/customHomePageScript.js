// This is my custom script for the homepage
// BE FORWARNED: I am an absolutely new to Javascript so these
// are my first attempts

document.addEventListener('DOMContentLoaded', function () {

    var searchState = document.getElementById('twitterScreenName');
    var btnState = document.getElementById('searchAcount');

    if (searchState.value === '') {
        btnState.disabled = true;
    }
    else {
        btnState.disabled = false;
    }
});

function didUserAddSearchTerm() {
    var searchState = document.getElementById('twitterScreenName');
    var btnState = document.getElementById('searchAcount');

    if (searchState.value == '') {
        btnState.disabled = true;
        alert("Enter a screen name to search for tweets");
        searchState.focus();
    }
    else {
        btnState.disabled = false;
    }
};


document.addEventListener('DOMContentLoaded', function () {
    var c = document.getElementById('current-time');
    
    setInterval(updateTime, 1000);

    function updateTime() {
        var d = new Date();

        var hours = d.getHours(),
            minutes = d.getMinutes();
            ampm = 'AM';

        if (hours > 12) {
            hours -= 12;
            ampm = "PM";
        } else if (hours === 0) {
            hours = 12;
        }

        if (minutes < 10) {
            minutes = '0' + minutes;
        }

        var sep = ':';
        if (d.getSeconds() % 2 === 1) sep = ' ';

        c.innerHTML = hours + sep + minutes + ' ' + ampm;
        
    }
});

document.addEventListener('DOMContentLoaded', function () {
    var date = document.getElementById('current-date');
    var d = new Date();
    date.innerHTML =d.getMonth() + '/' + d.getDate().toString() + '/' + d.getFullYear();
});