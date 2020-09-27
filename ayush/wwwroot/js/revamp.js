$(document).ready(function () {
    
     var base_url =  window.location.origin + '/';

  






    $("ul.navbar-nav .nav-item  .link-form").click(function (event) {
        event.preventDefault();

        $(".user-block-main").find(".user-block .set-item").hide();
        $(".user-block-main").find(".user-block .set-item.display").show();
        $(".user-block-main").addClass("in-center ");
        $("ul.navbar-nav .nav-item  ul.top-nav li .top-menu-block").hide();
        $("ul.navbar-nav .nav-item  ul.top-nav li span.click").removeClass("active");
        $("ul.navbar-nav .nav-item  .for-contact").find(".contact-form").hide();
        $("ul.navbar-nav .nav-item  .for-contact").find(".contact-details").show();
    });


    $(".user-block-main .user-close").click(function (event) {
        event.preventDefault();

        $(".user-block-main").removeClass("in-center");


    });


    $(".user-block #step-email-signup").click(function (event) {
        event.preventDefault();

        $(this).parents(".set-item").hide();
        $("#step-email-signup-section").show();
    });

    $(".user-block #school-step-one").click(function (event) {
        event.preventDefault();

        $(this).parents(".set-item").hide();
        $("#school-step-two").show();
    });

  


    $(".user-block #institution-step-one").click(function (event) {
        event.preventDefault();

        $(this).parents(".set-item").hide();
        $("#institution-step-two").show();
    });


    $(".user-block #step-form-stu").click(function (event) {
        event.preventDefault();

        $(this).parents(".set-item").hide();
        $("#step-email-signup-section").show();
    });

    $(".user-block #step-form-cdp").click(function (event) {
        event.preventDefault();

        $(this).parents(".set-item").hide();
        $("#step-form-section-cdp").show();
    });

    $(".user-block #step-form-cap").click(function (event) {
        event.preventDefault();

        $(this).parents(".set-item").hide();
        $("#step-form-section-cap").show();
    });
    
  $(".user-block #step-form-pro").click(function (event) {
        event.preventDefault();

        $(this).parents(".set-item").hide();
        $("#step-form-section-professional").show();
    });


    $(".user-block #professional-step-one").click(function (event) {
        event.preventDefault();

        $(this).parents(".set-item").hide();
        $("#professional-step-two").show();
    });

    $(".user-block #step-iccc").click(function (event) {
        event.preventDefault();

        $(this).parents(".set-item").hide();
        $("#step-iccc-section").show();
    });

// back

    $(".set-item a.back.to-main").click(function (event) {
        event.preventDefault();
        $('.validation').remove();
        $(this).parents(".set-item").hide();
        $(".set-item.display").show();
    });

    $(".set-item a.back.to-school-main").click(function (event) {
        event.preventDefault();
        $('.validation').remove();
        $(this).parents(".set-item").hide();
        $(".set-item.school-selection").show();
    });

    $(".set-item a.back.to-institution-main").click(function (event) {
        event.preventDefault();
        $('.validation').remove();
        $(this).parents(".set-item").hide();
        $(".set-item.institution-selection").show();
    });

    $(".set-item a.back.to-professional-main").click(function (event) {
        event.preventDefault();
        $('.validation').remove();
        $(this).parents(".set-item").hide();
        $(".set-item.professional-selection").show();
    });
// back
  if(window.matchMedia("(max-width: 767px)").matches)  
    {
      $("ul.navbar-nav .nav-item  ul.top-nav li span.click ").click(function (event) {
          event.preventDefault();  

          $(this).parents("li").find(".top-menu-block").toggle();
          $(this).toggleClass('active');
          $(this).parents("li").siblings().find(".top-menu-block").hide();
          $(this).parents("li").siblings().find("span.click").removeClass('active');
          $("ul.navbar-nav .nav-item  .for-contact").find(".contact-form").hide();
          $("ul.navbar-nav .nav-item  .for-contact").find(".contact-details").show();

          var blockHeight = $(this).parents("li").find(".top-menu-block").height();
          $(this).parents("li").find(".top-menu-block .for-contact").css('min-height', blockHeight);

      });
    }else{
        $("ul.navbar-nav .nav-item  ul.top-nav li span.click ").mouseover(function (event) {   
              //$("ul.navbar-nav .nav-item  .top-menu-block").hide();                          
              //$(this).parent().find('.top-menu-block').show();

              $(this).parents("li").find(".top-menu-block").toggle();
              $(this).toggleClass('active');

              $(this).parents("li").siblings().find(".top-menu-block").hide();
              $(this).parents("li").siblings().find("span.click").removeClass('active');



              $("ul.navbar-nav .nav-item  .for-contact").find(".contact-form").hide();
              $("ul.navbar-nav .nav-item  .for-contact").find(".contact-details").show();

              var blockHeight = $(this).parents("li").find(".top-menu-block").height();
              $(this).parents("li").find(".top-menu-block .for-contact").css('min-height', blockHeight);
      })
    }

    $("  ul.navbar-nav .nav-item  .for-menu .header-close ").click(function (event) {
        event.preventDefault();  
        $(this).toggleClass('active');
        $("ul.navbar-nav .nav-item  ").toggleClass('in-center');
        $("ul.navbar-nav .nav-item  ul.top-nav li span.click ").removeClass('active');
        $("ul.navbar-nav .nav-item  ul.top-nav li .top-menu-block").hide();
        $("ul.navbar-nav .nav-item  .for-contact").find(".contact-form").hide();
        $("ul.navbar-nav .nav-item  .for-contact").find(".contact-details").show();
        
       
    });
 








    $("ul.navbar-nav .nav-item  ul.top-nav li .top-menu-block .top-menu-close").click(function (event) {
        event.preventDefault();
     
        $(this).parents(".top-menu-block").hide();
        $("ul.navbar-nav .nav-item  ul.top-nav li span.click").removeClass("active");

    });



    $("ul.navbar-nav .nav-item  .for-contact .send-message").click(function (event) {
        event.preventDefault();
        $("ul.navbar-nav .nav-item  .for-contact").find(".contact-form").slideDown();
        $("ul.navbar-nav .nav-item  .for-contact").find(".contact-details").slideUp();

    });

    $("ul.navbar-nav .nav-item  .for-contact .contact-form .btn-default").click(function (event) {
        event.preventDefault();
        $("ul.navbar-nav .nav-item  .for-contact").find(".contact-form").slideUp();
        $("ul.navbar-nav .nav-item  .for-contact").find(".contact-details").slideDown();

    });


    

});

