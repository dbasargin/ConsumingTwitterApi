
var map;
function initMap() {
    var seattle = { lat: 47.6062, lng: -122.3321 }
    var tacoma = { lat: 47.2529, lng: -122.4443 }
    var centerLatLng = { lat: 47.45, lng: -122.4 }

    map = new google.maps.Map(document.getElementById('hplus-map'), {
        'center': centerLatLng,
        'zoom' : 9,
        'mapTypeId': google.maps.MapTypeId.HYBRID
    });

    var markerSeattle = new google.maps.Marker({
        'position' : seattle,
        'map' : map,
        'title': 'Welcome to Seattle'
    });

    var markerTacoma = new google.maps.Marker({
        'position': tacoma,
        'map': map,
        'title': 'Welcome to Tacoma'
    });

    var seattleContent = "Seattle<br>"
    seattleContent += "It rains alot here and is where I am going to get hired<br>"
    seattleContent += "by a fortunate company<br>"
    seattleContent += "Email me: dennisbasargin@gmail.com"

    var tacomaContent = "Tacoma<br>"
    tacomaContent += "It rains here too, I would be happy<br>"
    tacomaContent += "with a job here too<br>"
    tacomaContent += ":Just saying.. call me"

    var infowindow = new google.maps.InfoWindow({
        'content': seattleContent
    });

    var infoTwindow = new google.maps.InfoWindow({
        'content': tacomaContent
    });

    markerSeattle.addListener('click', function () {
        infowindow.open(map, markerSeattle);
        
    });

    markerTacoma.addListener('click', function () {
        infoTwindow.open(map, markerTacoma);
    });
}
