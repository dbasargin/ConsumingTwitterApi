// This is my custom script for the homepage
// I am learning Javascript from Lynda.com
// I am applying what I am learning to this project. 


function prepareEventHandlers() {
    document.getElementById("search-form").onsubmit = function () {
        if (document.getElementById("txtBxSName").value == "") {
            document.getElementById("error-message").innerHTML = "Please enter a twitter screen name";
            return false;
        }else{
            document.getElementById("error-message").innerHTML = "";
            return true;
        }
    };
}
window.onload = function () {
    prepareEventHandlers();
}

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