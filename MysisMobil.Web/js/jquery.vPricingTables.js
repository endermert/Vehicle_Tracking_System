// JavaScript Document
Cufon.replace(" .vlists h2 , .slideshow li h2");
Cufon.replace(".signup a",{ textShadow:"1px 1px 0px #2097ea" });
Cufon.replace(".featured .signup a",{ textShadow:"1px 1px 0px #6b000f" });
$(function(){
	
$.fn.vPricingTables = function(options){
	var defaults = {  size:"4x" };
	var options = $.extend(defaults, options);
	
	$(this).addClass("vholder");
	$(this).wrap("<div class='vTables' />");
	var width,root = $(this).parent();
	var plans = root.find(".vlists ul");
	
	switch(options.size)
	{
		case "4x" : root.width(960); width = "4x"; break;
		case "3x" : root.width(750); width = "3x"; break;
		case "2x" : root.width(600); width = "2x"; break;
		case "custom" : width = "custom";  break;
	}
	
	var sliderStage = root.find(".vholder>ul:first").addClass("slideshow");
	var temp = 0;
	
	if(width!="custom"){
	switch(plans.length)
	{
		case 2: root.addClass("cols2"+width); break;
		case 3: root.addClass("cols3"+width); break;
		case 4: root.addClass("cols4"+width); break;
		case 5: root.addClass("cols5"+width); break;
		
	}
	}
	plans.each(function(){  $(this).find(" li:first").addClass("signup");  $(this).find("li:eq(1)").addClass("planname"); });
	
	
	if($.browser.webkit)
	$(sliderStage.find("img")).load(function(){ 
	sliderStage.css({  height:sliderStage.children("li:first").height()+50 });
	sliderStage.children("li:first").css("visibility","visible");  });
	else
	{
	sliderStage.css({ height:sliderStage.children("li:first").height()+50 });
	sliderStage.children("li:first").css("visibility","visible");
	}

    root.find(".vlists ul:nth-child(2n+2)").addClass("even"); 
	 
	plans.hover(function(){ 
	if($.browser.msie)
	{
		plans.removeClass("fallback-border-default fallback-border-featured");
		if($(this).hasClass("featured"))
		$(this).addClass("fallback-border-featured");
		else
		$(this).addClass("fallback-border-default");
	}
	
	if(temp==$(this).index(".vlists ul")) return;
	
	
	
	
	sliderStage.css({  height:$(".slideshow li").eq($(this).index(".vlists ul")).height()+50 });
	 
	root.find(".slideshow li").css("visibility","hidden"); temp = $(this).index(".vlists ul");  
	root.find(".slideshow li").eq(temp).css("visibility","visible");  });
	
	
};

});
	
