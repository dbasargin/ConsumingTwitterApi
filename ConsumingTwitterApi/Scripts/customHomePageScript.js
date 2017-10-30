// This is my custom script for the homepage
// I am learning Javascript from Lynda.com
// I am applying what I am learning to this project. 


//if search textbox is empty, disable display button
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

//displays the time on homepage
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

//displays date on homepage
document.addEventListener('DOMContentLoaded', function () {
    var date = document.getElementById('current-date');
    var d = new Date();
    date.innerHTML =d.getMonth() + '/' + d.getDate().toString() + '/' + d.getFullYear();
});