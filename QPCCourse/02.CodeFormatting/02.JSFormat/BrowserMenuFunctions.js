(function () {
    "use strict";
    var theLayer,
        window,
        navigator,
        Event,
        event,
        document,

        positionX = 0,
        positionY = 0,

        b = navigator.appName,

        addScroll = false;

    if ((navigator.userAgent.indexOf('MSIE 5') > 0) || (navigator.userAgent.indexOf('MSIE 6')) > 0) {
        addScroll = true;
    }

    document.onmousemove = mouseMove;

    if (b === "Netscape") {
        document.captureEvents(Event.MOUSEMOVE);
    }

    function PopTip() {
        if (b === "Netscape") {
            theLayer = document.layers.ToolTip;
            if ((positionX + 120) > window.innerWidth) {
                positionX = window.innerWidth - 150;
            }

            theLayer.left = positionX + 10;
            theLayer.top = positionY + 15;
            theLayer.visibility = 'show';
        } else {
            theLayer = document.all.ToolTip;
            if (theLayer) {
                positionX = event.x - 5;
                positionY = event.y;

                if (addScroll) {
                    positionX = positionX + document.body.scrollLeft;
                    positionY = positionY + document.body.scrollTop;
                }

                if ((positionX + 120) > document.body.clientWidth) {
                    positionX = positionX - 150;
                }

                theLayer.style.pixelLeft = positionX + 10;
                theLayer.style.pixelTop = positionY + 15;
                theLayer.style.visibility = 'visible';
            }
        }
    }

    function mouseMove(evn) {
        if (b === "Netscape") {
            positionX = evn.pageX - 5;
            positionY = evn.pageY;
        } else {
            positionX = event.x - 5;
            positionY = event.y;
        }

        if (b === "Netscape") {
            if (document.layers.ToolTip.visibility === 'show') {
                PopTip();
            }
        } else {
            if (document.all.ToolTip.style.visibility === 'visible') {
                PopTip();
            }
        }
    }

    function HideTip() {
        if (b === "Netscape") {
            document.layers.ToolTip.visibility = 'hide';
        } else {
            document.all.ToolTip.style.visibility = 'hidden';
        }
    }

    function HideMenu1() {
        if (b === "Netscape") {
            document.layers.menu1.visibility = 'hide';
        } else {
            document.all.menu1.style.visibility = 'hidden';
        }
    }

    function ShowMenu1() {
        if (b === "Netscape") {
            theLayer = document.layers.menu1;
            theLayer.visibility = 'show';
        } else {
            theLayer = document.all.menu1;
            theLayer.style.visibility = 'visible';
        }
    }

    function HideMenu2() {
        if (b === "Netscape") {
            document.layers.menu2.visibility = 'hide';
        } else {
            document.all.menu2.style.visibility = 'hidden';
        }
    }

    function ShowMenu2() {
        if (b === "Netscape") {
            theLayer = document.layers.menu2;
            theLayer.visibility = 'show';
        } else {
            theLayer = document.all.menu2;
            theLayer.style.visibility = 'visible';
        }
    }
})();