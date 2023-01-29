
$(document).ready(function () {
    $('.slider').slick({
        dots: true,
        infinite: true,
        speed: 300,
        autoplay: true,
        slidesToScroll: 1,
        autoplaySpeed: 10000,
        slidesToShow: 1,
    });
    $('.slider2').slick({
        

        draggable: true,
        autoplay: true,
        autoplaySpeed: 4000,
        arrows: false,
        fade: true,
        speed: 600,
        infinite: true,
        cssEase: 'ease-in-out',
        touchThreshold: 100
    });
    $('.brandslider').slick({
        dots: true,
        infinite: true,
        speed: 300,
        autoplay: true,
        slidesToScroll: 1,
        autoplaySpeed: 10000,
        slidesToShow: 1,
    });
    $('.brandslider1').slick({
        dots: true,
        infinite: true,
        speed: 300,
        autoplay: true,
        slidesToScroll: 2,
        autoplaySpeed: 10000,
        slidesToShow: 2,
    });
    
    AOS.init();
   
  

});
$(document).ready(function openNav() {
        document.getElementById("mySidenav").style.width = "250px";
        document.getElementById("main").style.marginLeft = "250px";
    }

   

);
$(document).ready(function closeNav() {
        document.getElementById("mySidenav").style.width = "0";
        document.getElementById("main").style.marginLeft = "0";
    }

);