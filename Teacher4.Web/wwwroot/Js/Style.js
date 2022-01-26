  /*-------Dropdown--------*/
$(document).ready(function(){
  $(".navbar-burger").click(function(){
  $(".navbar-burger").toggleClass("is-active");
  $(".navbar-menu").toggleClass("is-active");
})
})
  /*------ modal -------
  $(".user").click(function(){
    $("#login").addClass("is-active");
  });

  $("#dellogin").click(function(){
    $("#login").removeClass("is-active");
  });
  /* Tab Modal 
  const tabs = document.querySelectorAll('.tabs li');
  const tabContentBoxes = document.querySelectorAll('#tab-content > div');
  
  tabs.forEach(tab => {
    tab.addEventListener('click', () => {
      tabs.forEach(item => item.classList.remove('is-active'));
      tab.classList.add('is-active');
  
      const target = tab.dataset.target;
      // console.log(target);
      tabContentBoxes.forEach(box => {
        if (box.getAttribute('id') === target) {
          box.classList.remove('is-hidden');
        } else {
          box.classList.add('is-hidden');
        }
      })
    })
  })*/
