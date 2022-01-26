/*-------dropdown------*/
$('.icon1').click(function(){
    $('span').toggleClass("cancel");
  });

/*--------Search------*/
$("#search").click(function(){
    $("#divSearch").fadeToggle(1000);
  });
  
  
  /*------- Slider ------*/
jQuery(document).ready(function ($) {
  let slider = $('.owl-carousel');
  slider.each(function () {
      $(this).owlCarousel({
          nav: true,
          loop: true,
          dots: false,
          rtl:true,
          pagination: false,
          margin: 15,
          autoHeight: false,
          stagePadding: 20,
          responsive: {
              0: {
                  items: 1,
                  stagePadding: 0,
                  margin: 30,
              },
              700: {
                  items: 3,
                  stagePadding: 35,
              },
              1000: {
                  items: 4,
                  stagePadding: 70,
              }
          }
      });
  });
});