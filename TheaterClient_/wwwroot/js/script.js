
function toggleLogin(id) {
    targ = document.getElementById(id);
    if (targ.className.search("hidden") == -1) {
        targ.className = "login hidden";
    }
    else {
        targ.className = "login";
    }
}
