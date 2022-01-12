
function toggleLogin(id) {
    targ = document.getElementById(id);
    if (targ.className.search("hidden") == -1) {
        targ.className = "login hidden";
    }
    else {
        targ.className = "login";
    }
}


function toggleBooking(id) {
    targ = document.getElementById(id);
    if (targ.className.search("hidden") == -1) {
        targ.className = "formcontainer hidden";
    }
    else {
        targ.className = "formcontainer";
    }
}
