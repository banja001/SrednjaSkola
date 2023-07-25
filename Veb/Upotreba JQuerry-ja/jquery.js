$(document).ready(function(){
  $(".button-hide1").click(function(){
    $(".tekst1").hide(1000);
  });
});
$(document).ready(function(){
  $(".button-show1").click(function(){
    $(".tekst1").show(1000);
  });
});
/*  */
$(document).ready(function(){
  $(".slide-visible").click(function(){
    $(".slide-hidden").slideToggle("fast");
  });
});
/* */
$(document).ready(function(){
  $(".animate-button").click(function(){
    var div = $(".animate-div");
    div.animate({fontSize: '50px'});
    div.animate({opacity: '0'}, "slow");
    div.animate({opacity: '1'}, "slow");
  });
  $(".stop-button").click(function()
  {
    $(".animate-div").stop();
  });
});
/* */
$(document).ready(function(){
  $(".tv-button").click(function(){
    $("ol").append("<li>Dodali ste u korpu TV</li>");
  });
});
$(document).ready(function(){
  $(".laptop-button").click(function(){
    $("ol").append("<li>Dodali ste u korpu laptop</li>");
  });
});
$(document).ready(function(){
  $(".fotoaparat-button").click(function(){
    $("ol").append("<li>Dodali ste u korpu fotoaparat</li>");
  });
});
$(document).ready(function(){
  $(".alarm-button").click(function(){
    $("ol").append("<li>Dodali ste u korpu alarm</li>");
  });
});
var counter = 0;
var counterTv = 0;
var counterFotoaparat = 0;
var counterAlarm = 0;
var counterLaptop = 0;
$(document).ready(function() {

    $(".dodaj-button").click(function(){
        counter++;

        $("#brojac").text(counter);
    });

});

$(document).ready(function() {

  $(".tv-button").click(function(){
      counterTv++;

      $("#brojacTv").text(counterTv);
  });

});

$(document).ready(function() {

  $(".fotoaparat-button").click(function(){
      counterFotoaparat++;

      $("#brojacFotoaparat").text(counterFotoaparat);
  });

});

$(document).ready(function() {

  $(".alarm-button").click(function(){
      counterAlarm++;

      $("#brojacAlarm").text(counterAlarm);
  });

});

$(document).ready(function() {

  $(".laptop-button").click(function(){
      counterLaptop++;

      $("#brojacLaptop").text(counterLaptop);
  });

});

$(document).ready(function(){
  $(".remove-button").click(function(){
    $("ol").remove();
  });
});
