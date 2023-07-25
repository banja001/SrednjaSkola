var i=0;
var j=0;
var u=0;
var p;
var n;
$(document).ready(function(){
  $("#1").click(function(){
    $("#1").toggleClass("polja1");
	i++;
	});
});
$(document).ready(function(){
  $("#2").click(function(){
    $("#2").toggleClass("polja2");
	i++;
  });
});
$(document).ready(function(){
  $("#3").click(function(){
$("#3").toggleClass("polja3");  
i++;
	});
});
$(document).ready(function(){
  $("#4").click(function(){
	$("#4").toggleClass("polja4");
	i++;
  });
});
$(document).ready(function(){
  $("#5").click(function(){
   $("#5").toggleClass("polja5");
   i++;
  });
});
$(document).ready(function(){
  $("#6").click(function(){
   $("#6").toggleClass("polja6");
   i++;
   
  });
});
$(document).ready(function(){
  $("#7").click(function(){
    $("#7").toggleClass("polja7");
	i++;
  });
});
$(document).ready(function(){
  $("#8").click(function(){
    $("#8").toggleClass("polja8");
	i++;
  });
});
$(document).ready(function(){
  $("#9").click(function(){
    $("#9").toggleClass("polja9");
	i++;
  });
});
$(document).ready(function(){
  $("#b1").click(function(){
    $("#p1").append("Dodao si tekst! ");
	});
});
  $(document).ready(function(){
  $("#b2").click(function(){
    $("#p1").empty();
  });
});
$(document).ready(function(){
  $("#b3").click(function(){
    $("#i1").toggle(500);
  });
});
$(document).ready(function(){
  $("#b4").click(function(){
    $("#i2").animate({
      height: '+=25px',
      width: '+=50px'
    });
	j++;
  });
});


$(document).ready(function(){
  $("#b5").click(function(){
	var m;
	n=document.getElementById('poeni2');
	m=document.getElementById('inp2').value;
	if(m=="Majmun"||m=="majmun"||m=="Orangutan"||m=="orangutan")
	{
	$("#i2").addClass("cvika");
	switch(j)
	{
	case 0: n.innerHTML="Osvojio si 100 poena!";u=u+100;break;
	case 1: n.innerHTML="Osvojio si 90 poena!";u=u+90;break;
	case 2: n.innerHTML="Osvojio si 80 poena!";u=u+80;break;
	case 3: n.innerHTML="Osvojio si 70 poena!";u=u+70;break;
	case 4: n.innerHTML="Osvojio si 60 poena!";u=u+60;break;
	case 5: n.innerHTML="Osvojio si 50 poena!";u=u+50;break;
	case 6: n.innerHTML="Osvojio si 40 poena!";u=u+40;break;
	case 7: n.innerHTML="Osvojio si 30 poena!";u=u+30;break;
	case 8: n.innerHTML="Osvojio si 20 poena!";u=u+20;break;
	case 9: n.innerHTML="Osvojio si 10 poena!";u=u+10;break;
	default: n.innerHTML="Osvojio si 5 poena!";u=u+5;break;
	}
	}
	else
		n.innerHTML="Pogrešan odgovor!";
  });
});
$(document).ready(function(){
  $("#b6").click(function(){
	var s;
	p=document.getElementById('poeni');
	s=document.getElementById('inp').value;
	if(s=="zemlja"||s=="Zemlja"||s=="Planeta Zemlja"||s=="planeta zemlja"||s=="planeta Zemlja"||s=="Planeta zemlja")
	{
    $("#1,#2,#3,#4,#5,#6,#7,#8,#9").remove();
	$("#aa").addClass("cela");
	switch(i)
	{
	case 1: p.innerHTML="Osvojio si 100 poena!";u=u+100;break;
	case 2: p.innerHTML="Osvojio si 90 poena!";u=u+90;break;
	case 3: p.innerHTML="Osvojio si 80 poena!";u=u+80;break;
	case 4: p.innerHTML="Osvojio si 70 poena!";u=u+70;break;
	case 5: p.innerHTML="Osvojio si 60 poena!";u=u+60;break;
	case 6: p.innerHTML="Osvojio si 50 poena!";u=u+50;break;
	case 7: p.innerHTML="Osvojio si 40 poena!";u=u+40;break;
	case 8: p.innerHTML="Osvojio si 30 poena!";u=u+30;break;
	case 9: p.innerHTML="Osvojio si 20 poena!";u=u+20;break;
	default: p.innerHTML="Osvojio si 10 poena!";u=u+10;break;
	}
	}
	else
		p.innerHTML="Pogrešan odgovor!";
  });
});
$(document).ready(function(){
 $("#b69").click(function(){
  $("#p69").html(function(){
    return "Osvojili ste ukupno "+u+" poena!"; 
  });
  });
});