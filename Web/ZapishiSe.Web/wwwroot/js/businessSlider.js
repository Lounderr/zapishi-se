
$('.slider').slick({
    dots: true,
    arrows: true,
    dotsClass: 'slider-dots',
    prevArrow: '<button type="button" class="slide-btn left-arrow">Prev</button>',
    nextArrow: '<button type="button" class="slide-btn right-arrow">Next</button>',
});


document.addEventListener('DOMContentLoaded', function () {
    let zooming = new Zooming({
        onBeforeOpen: function (target) {
            let copy = target.cloneNode(true);
            copy.id = "zoomOldLoc";
            target.before(copy);

            target.classList = "img-zoomable"
            document.body.insertBefore(target, document.body.firstChild);
        },
        onBeforeClose: function (target) {
            let copy = document.getElementById("zoomOldLoc");
            copy.after(target);
            target.classList = copy.classList;
            copy.remove();

        },
    }).listen('.img-zoomable')

    zooming.config({
        transitionDuration: 0.25,
        enableGrab: false,
        // scaleExtra: 1.2,
        transitionTimingFunction: "cubic-bezier(0.4, 0, 0, 1)",
        bgColor: '#222'
    })
});