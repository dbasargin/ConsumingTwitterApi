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