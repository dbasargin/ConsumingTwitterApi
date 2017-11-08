
    //This script displays and interacts with the google maps api
var map;

// Seattle is the center coordinate of this Google Map
var seattle = { lat: 47.6062, lng: -122.3321 }

// COORDINATES of featured craft Cocktails Bars in Seattle
var tavernlaw = { lat: 47.613240, lng: -122.316512 }
var canon = { lat: 47.611372, lng: -122.316654 }
var zigZag = { lat: 47.608349, lng: -122.341607 }
var robRoy = { lat: 47.607007, lng: -122.316476 }
var baBar = { lat: 47.606978, lng: -122.316584 }
var barrio = { lat: 47.613669, lng: -122.316473 }

//This is the recommended Google Api Function to initialize a Map.
function initMap() {

    //div id location I display the google map
    map = new google.maps.Map(document.getElementById('hplus-map'), {
        'center': seattle,
        'zoom': 14,
        'mapTypeId': google.maps.MapTypeId.HYBRID
    });


    //Create MARKERS For Featured Craft Cocktail Bars in Seattle
    var markerTavernlaw = new google.maps.Marker({
        'position': tavernlaw,
        'map': map,
        'title': 'Great Cocktail Bar with speakeasy'
    });

    var markerCanon = new google.maps.Marker({
        'position': canon,
        'map': map,
        'title': 'Larget Whiskey Collection In US'
    });

    var markerZigzag = new google.maps.Marker({
        'position': zigZag,
        'map': map,
        'title': 'Former employer of Murry The Blur'
    });

    var markerRobroy = new google.maps.Marker({
        'position': robRoy,
        'map': map,
        'title': 'Simply spectacular lounge'
    });

    var markerBabar = new google.maps.Marker({
        'position': baBar,
        'map': map,
        'title': 'Best Vietnemese food ever and great cocktails'
    });

    var markerBarrio = new google.maps.Marker({
        'position': barrio,
        'map': map,
        'title': 'This place is all around good'
    });

    //DESCRIPTIONS for Bars
    var tavernlawContent = "Tavern Law<br>"
    tavernlawContent += "Address: 12th Avenue, Seattle, WA<br>"
    tavernlawContent += "tavernlaw.com"

    var canonContent = "Canon<br>"
    canonContent += "928 12th Ave, Seattle, WA 98122<br>"
    canonContent += "canonseattle.com"

    var zigzagContent = "ZigZag Cafe<br>"
    zigzagContent += "1501 Western Ave #202, Seattle, WA 98101<br>"
    zigzagContent += "zigzagseattle.com<br>"
    zigzagContent += "(206) 625-1146"

    var robroyContent = "Rob Roy<br>"
    robroyContent += "2332 2nd Ave, Seattle, WA 98121<br>"
    robroyContent += "robroyseattle.com<br>"
    robroyContent += "(206) 956-8423"

    var babarContent = "Ba Bar<br>"
    babarContent += "550 12th Ave, Seattle, WA 98122<br>"
    babarContent += "babarseattle.com<br>"
    babarContent += "(206) 328-2030"

    var barrioContent = "Barrio Mexican Kitchen & Bar<br>"
    barrioContent += "1420 12th Ave, Seattle, WA 98122<br>"
    barrioContent += "barriorestaurant.com<br>"
    barrioContent += "(206) 588-8105"

    //INFOWINDOWS for Bars
    var infowindowTavernlaw = new google.maps.InfoWindow({
        'content': tavernlawContent
    });
    var infowindowCanon = new google.maps.InfoWindow({
        'content': canonContent
    });
    var infowindowZigzag = new google.maps.InfoWindow({
        'content': zigzagContent
    });
    var infowindowRobroy = new google.maps.InfoWindow({
        'content': robroyContent
    });
    var infowindowBabar = new google.maps.InfoWindow({
        'content': babarContent
    });
    var infowindowBarrio = new google.maps.InfoWindow({
        'content': barrioContent
    });

    //LISTENENERS for Bar Markers
    markerTavernlaw.addListener('click', function () {
        infowindowTavernlaw.open(map, markerTavernlaw);
    });
    markerCanon.addListener('click', function () {
        infowindowCanon.open(map, markerCanon);
    });
    markerZigzag.addListener('click', function () {
        infowindowZigzag.open(map, markerZigzag);
    });
    markerRobroy.addListener('click', function () {
        infowindowRobroy.open(map, markerRobroy);
    });
    markerBabar.addListener('click', function () {
        infowindowBabar.open(map, markerBabar);
    });
    markerBarrio.addListener('click', function () {
        infowindowBarrio.open(map, markerBarrio);
    });

    // TRIGGERS bar markers click events when bar links are clicked outside of the Maps window, 
    // which will open the InfoWindows inside the maps window
    $('#TavernLaw').click(function () {
        google.maps.event.trigger(markerTavernlaw, 'click')
    })
    $('#Canon').click(function () {
        google.maps.event.trigger(markerCanon, 'click')
    })
    $('#ZigZag').click(function () {
        google.maps.event.trigger(markerZigzag, 'click')
    })
    $('#RobRoy').click(function () {
        google.maps.event.trigger(markerRobroy, 'click')
    })
    $('#BaBar').click(function () {
        google.maps.event.trigger(markerBabar, 'click')
    })
    $('#Barrio').click(function () {
        google.maps.event.trigger(markerBarrio, 'click')
    })
    
}