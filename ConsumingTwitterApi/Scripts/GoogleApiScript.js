
//This script displays and interacts with the google maps api
var map;
function initMap() {
    
    var seattle = { lat: 47.6062, lng: -122.3321 }
    var tacoma = { lat: 47.2529, lng: -122.4443 }
    var centerLatLng = { lat: 47.45, lng: -122.4 }

    //div id location I display the google map
    map = new google.maps.Map(document.getElementById('hplus-map'), {
        'center': centerLatLng,
        'zoom' : 9,
        'mapTypeId': google.maps.MapTypeId.HYBRID
    });

    //creates marker in Seattle
    var markerSeattle = new google.maps.Marker({
        'position' : seattle,
        'map' : map,
        'title': 'Welcome to Seattle'
    });

    //creates marker in Tacoma
    var markerTacoma = new google.maps.Marker({
        'position': tacoma,
        'map': map,
        'title': 'Welcome to Tacoma'
    });

    //Description of Seattle
    var seattleContent = "Seattle<br>"
    seattleContent += "It rains alot here and is where I am going to get hired<br>"
    seattleContent += "by a fortunate company<br>"
    seattleContent += "Email me: dennisbasargin@gmail.com"

    //description of Tacoma
    var tacomaContent = "Tacoma<br>"
    tacomaContent += "It rains here too, I would be happy<br>"
    tacomaContent += "with a job here too<br>"
    tacomaContent += ":Just saying.. call me"

    //create infoWindow on map and adds Seattle description
    var infowindow = new google.maps.InfoWindow({
        'content': seattleContent
    });

    //create infoWindow on map and adds Tacoma description
    var infoTwindow = new google.maps.InfoWindow({
        'content': tacomaContent
    });

    //add event listener to marker and display Seattle description when marker is clicked
    markerSeattle.addListener('click', function () {
        infowindow.open(map, markerSeattle);
        
    });

    //add event listener to marker and display Tacoma description when marker is clicked
    markerTacoma.addListener('click', function () {
        infoTwindow.open(map, markerTacoma);
    });
}
