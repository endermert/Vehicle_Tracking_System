/*
 * jQuery Chop Slider v.1.1.0
 * http://www.idangero.us/cs
 *
 * Copyright 2011, Vladimir Kharlampidi
 * The iDangero.us
 * http://www.idangero.us
 
 * Licensed under the MIT license.
 * Date: July 09, 2011
 */

(function($) { $.fn.chopSlider = function(a) {

	$.chopSlider = {};
	
	if(!a) a = {};
	
	
	/*Default Values*/
	
	a.autoplay = a.autoplay||false,
	a.autoplayDelay = a.autoplayDelay||10000,
	a.useCaptions = a.useCaptions || false,
	a.captionTransform = a.captionTransform || "scale(0) rotate(45deg) translateX(-800)",
	a.rotate = a.rotate||0;
	a.scaleY = (a.scaleY||a.scaleY===0)?a.scaleY: 1;
	a.scaleX = (a.scaleX||a.scaleX===0)?a.scaleX: 1;
	a.translateX = (a.translateX||a.translateX===0)?a.translateX: 0;
	a.translateY = (a.translateY||a.translateY===0)?a.translateY: 0;
	a.ease1 = a.ease1 || "ease";
	a.ease2 = a.ease2 || "ease";
	a.origin = a.origin||"50% 50%";
	a.xOffset = a.xOffset||0;
	a.yOffset = a.yOffset||0;
	a.hPieces = a.hPieces>0?a.hPieces: 10;
	a.vPieces = a.vPieces>0?a.vPieces: 10;
	a.dur1 = a.dur1>=0?a.dur1: 1000;
	a.dur2 = a.dur2>=0?a.dur2: 600;
	a.dur3 = a.dur3>=0?a.dur3: 1000;
	a.type = a.type || "vertical";
	a.rotateSymmetric = (a.rotateSymmetric===true||a.rotateSymmetric===false)?a.rotateSymmetric:true
	a.disableCSS3 = (a.disableCSS3===true||a.disableCSS3===false)?a.disableCSS3:false
	a.pieceDelay = a.pieceDelay>=0?a.pieceDelay: 50;
	a.xFadeDelay = a.xFadeDelay>=0?a.xFadeDelay: 300;
	a.hideControls = (a.hideControls===true||a.hideControls===false)?a.hideControls:true
	if(a.mobile) {
		if(isMobile()) {
			if (a.mobile.disableCSS3) a.disableCSS3 = a.mobile.disableCSS3;
		}
	}
	
	/* Function to detect mobile devices */
	
	function isMobile() {
		var csUA = navigator.userAgent;
		if(csUA.indexOf('ndroid')>= 0||csUA.indexOf('iPhone')>= 0||csUA.indexOf('iPod')>= 0||csUA.indexOf('BlackBerry')>= 0||csUA.indexOf('Symbian')>= 0||csUA.indexOf('Mobile')>= 0) {
			return true;
		}
		else {
			return false;
		}
		
	}
	
	/* Redefine Parameters Function */
	
	$.chopSlider.redefine = function(b) {
		if(b) {
			c={};
			$.extend(c,a,b);
			a = c;
			if(a.autoplay===false) clearInterval($.chopSlider.autoplay);
			else {
				autoPlay();	
			}
		}
	}
	
	/*CSS3 Transitions Test*/
	
	function hasCSS3() {
		var bodyDoc = document.body || document.documentElement;
		var bds = bodyDoc.style;
		var s = bds.transition !== undefined || bds.WebkitTransition !== undefined || bds.MozTransition !== undefined || bds.MsTransition !== undefined || bds.OTransition !== undefined;
		$.chopSlider.hasCSS3 = function(){return s};
	}
	hasCSS3();
	function withCSS3(){
		return 	($.chopSlider.hasCSS3() && !a.disableCSS3)
	}
	
	/*CSS3 Transition Function*/
	
	(function($) {
		$.fn.csTransform = function(params,callback) {
			if(!withCSS3()) return this;
			if(arguments.length==0) return this;
			if(arguments.length==3) {
				var params2 = {}
				params2.transform = arguments[0];
				params2.time = arguments[1];
				callback = arguments[2];
				var params = {}
				params.transform = params2.transform;
				params.time = params2.time;
				
			}
			if(arguments.length<=2) {
				if(typeof(params)=="string") {
					var params2 = {}
					params2.transform = arguments[0];
					if(arguments.length==2) {
						if(typeof(arguments[1])=="number"||typeof(arguments[1])=="string") {
							params2.time = arguments[1];
							callback="";
						}
						else {
							params2.time = 0;
							callback = arguments[1];
						}
					}
					else {params2.time = 0;}
					var params = {}
					params.transform = params2.transform;
					params.time = params2.time;
				}
				else {
					params.time = params.time||0;
					params.transform = params.transform || "";
				}
			}
			params.delay = params.delay||0;
			params.ease = params.ease || "ease";
			params.origin = params.origin || "50% 50%";
			if (callback) {
				var transformedObj = this;
				transformedObj.returnTransformCallback = callback;
				setTimeout(function() { transformedObj.returnTransformCallback() },params.time)
			}
			return this.each(function(){
				$(this).css({
				"-webkit-transform":params.transform,
				"-webkit-transition-property":"-webkit-transform"+(params.animateOrigin?" ,-webkit-transform-origin":""),
				"-webkit-transition-duration":""+params.time/1000+"s",
				"-webkit-transition-delay":""+params.delay/1000+"s",
				"-webkit-transition-timing-function":""+params.ease,
				"-webkit-transform-origin":""+params.origin,
				"-o-transform":params.transform,
				"-o-transition-property":"-o-transform"+(params.animateOrigin?" ,-o-transform-origin":""),
				"-o-transition-duration":""+params.time/1000+"s",
				"-o-transition-delay":""+params.delay/1000+"s",
				"-o-transition-timing-function":""+params.ease,
				"-o-transform-origin":""+params.origin,
				"-moz-transform":params.transform,
				"-moz-transition-property":"-moz-transform"+(params.animateOrigin?" ,-moz-transform-origin":""),
				"-moz-transition-duration":""+params.time/1000+"s",
				"-moz-transition-delay":""+params.delay/1000+"s",
				"-moz-transition-timing-function":""+params.ease,
				"-moz-transform-origin":""+params.origin,
				"-ms-transition-property":"-ms-transform"+(params.animateOrigin?" ,-ms-transform-origin":""),
				"-ms-transition-duration":""+params.time/1000+"s",
				"-ms-transition-delay":""+params.delay/1000+"s",
				"-ms-transition-timing-function":""+params.ease,
				"-ms-transform-origin":""+params.origin,
				"transition-property":"transform"+(params.animateOrigin?" ,transform-origin":""),
				"transition-duration":""+params.time/1000+"s",
				"transition-delay":""+params.delay/1000+"s",
				"transition-timing-function":""+params.ease,
				"transform-origin":""+params.origin
				})	
			})
		}
	})(jQuery);
	
	
	/*  ------------------------  Only csChop() function ----------------------------- */
	
	
	(function($) {
		$.fn.csChop = function(p,duration,callback) {
			if(this.length==0) return;
			return this.each(function(){
			
			/*  Default Parameters */
			
			p.zIndex = p.zIndex || 20000;
			p.rotate = p.rotate||0;
			p.scaleY = (p.scaleY||p.scaleY===0)?p.scaleY: 1;
			p.scaleX = (p.scaleX||p.scaleX===0)?p.scaleX: 1;
			p.translateX = (p.translateX||p.translateX===0)?p.translateX: 0;
			p.translateY = (p.translateY||p.translateY===0)?p.translateY: 0;
			p.ease = p.ease || "ease";
			p.origin = p.origin||"50% 50%";
			p.xOffset = p.xOffset||0;
			p.yOffset = p.yOffset||0;
			p.hPieces = p.hPieces>0?p.hPieces: 10;
			p.vPieces = p.vPieces>0?p.vPieces: 10;
			p.dur = duration>=0?duration: 1000;
			p.type = p.type || "vertical";
			p.rotateSymmetric = (p.rotateSymmetric===true||p.rotateSymmetric===false)?p.rotateSymmetric:true
			p.disableCSS3 = (p.disableCSS3===true||p.disableCSS3===false)?p.disableCSS3:false
			p.pieceDelay = p.pieceDelay>=0?p.pieceDelay: 0;
			p.width = $(this).outerWidth();
			p.height = $(this).outerHeight();
			p.hideSrc = (p.hideSrc===true||p.hideSrc===false)?p.hideSrc:true
			if(!p.allowMultiChop) {
				if($(this).attr("data-csid")&&$(".csChopper[data-csid='"+$(this).attr("data-csid")+"']").length>0) return;
			}
			
			
			/* Get new chopper ID */
			
			var newCsID = $(".csChopper:last").attr("data-csid");
			if(!newCsID) {
				newCsID = 0;
			}
			else newCsID++;
			
			/* Add Loader Container */
			$("body").append('<div class="csChopper" data-csid="'+newCsID+'"><div class="csChopper-dummy"></div></div>')
			var loader = $('.csChopper[data-csid="'+newCsID+'"]');
			loader.css({
				left:$(this).offset().left,
				top:$(this).offset().top,
				position:"absolute",
				"z-index":p.zIndex,
				width:p.width,
				height:p.height,
				display:"none"
			})
			var limage = $(this);
			var bgSource;
			if($(this).attr("src")) bgSource = "url("+$(this).attr("src")+")";
			if($(this).css("background-image").indexOf("rl")>=0) bgSource = $(this).css("background-image")
			
			$(window).resize(function(){
				loader.css({left:limage.offset().left,top:limage.offset().top})	
			})
			
			limage.attr({"data-csid":newCsID})

			if(p.hideSrc){limage.css("visibility","hidden")}
			
			chopIt(p);
			
			/* Callback functions */
			
			function Callbacks(cal,id){
				this.loader = function(){return $('.csChopper[data-csid="'+id+'"]')};
				
				
				if(cal.type == "multi") {
					this.rows = function(){return this.loader().children("div:last").children("div")};
					this.slices = function(){return this.rows().find("div")}
				}
				else {
					this.slices = function(){return this.loader().children("div:last").find("div")}
					this.rows = this.slices()
				}
				
				this.src = function(){return $('[data-csid="'+id+'"]').not(".csChopper")};
				
				this.id = function(){ return id}

				this.reset = function(){
					this.loader().hide().remove();
					this.src().css({visibility:"visible"}).attr({"data-csid":""});
					return;
				}
				
				this.setBack = function(time,callback){
					this.setTo({scaleX:1,scaleY:1,rotate:0,xOffset:0,yOffset:0,translateX:0,translateY:0},time,callback)
				}
				
				this.redefine = function(calRf,callback) {
					var rdf = {};
					$.extend(rdf,cal);
					$.extend(cal,calRf);
					if(rdf.type == "multi") {
						var bgSource = this.loader().children(".csChopper-dummy:last").children("div").find("div").css('background-image')
					}
					else {
						var bgSource = this.loader().children("div:last").find("div").css('background-image')
					}
					this.loader().children(".csChopper-dummy:last").remove()
					this.loader().append('<div class="csChopper-dummy"></div>')
					
					fDummy = this.loader().children(".csChopper-dummy:last")

					if(cal.type=="multi") {
						var fDummy = loader.find(".csChopper-dummy")
						for (var i=1;i<=cal.hPieces;i++) {
							fDummy.append('<div ></div>')
						}
						fDummy.children("div").each(function(){
							for (var i=1;i<=cal.vPieces;i++) {
								$(this).append('<div></div>')
							}
						})
						fDummy.children("div").each(function(){
							var si = $(this).index()
							$(this).css({
								width:p.width,
								position:"absolute",
								top:p.height/cal.hPieces*si,
								left:0,
								height:p.height/cal.hPieces
							})
							.find("div").each(function(){
								var si = $(this).parent().index()
								var si2 = $(this).index()
								var rotateAngle = !cal.rotateSymmetric?-(-cal.rotate+cal.rotate*2*(si2+1)/cal.vPieces ):cal.rotate;
								$(this).css({
									width:!withCSS3()?p.width/cal.vPieces*cal.scaleX:p.width/cal.vPieces,
									height:!withCSS3()?p.height/cal.hPieces*cal.scaleY:p.height/cal.hPieces,
									position:"absolute",
									left:(p.width+cal.xOffset*2)/cal.vPieces*si2-cal.xOffset,
									top:cal.yOffset*2*si/cal.hPieces - cal.yOffset,
									"background-image":bgSource,
									backgroundPosition: -p.width/cal.vPieces*si2+"px "+-p.height/cal.hPieces*si+"px"
								})
								.csTransform({
									transform: "rotate("+rotateAngle+"deg) scaleY("+cal.scaleY+") scaleX("+cal.scaleX+") translate("+cal.translateX+"px,"+cal.translateY+"px)",
									delay:0,
									time:0,
									ease:cal.ease,
									origin:cal.origin,
									animateOrigin:cal.animateOrigin
								})
								cal.initSliceWidth = p.width/cal.vPieces
								cal.initSliceHeight = p.height/cal.hPieces
							})
						})
					}
					else {
						for (var i=1;i<=(p.type=="vertical"?p.vPieces:p.hPieces);i++) {
							fDummy.append('<div ></div>')
						}
						fDummy.children("div").each(function(){
							var si = $(this).index()
							$(this).css({
								width:withCSS3()?(cal.type=="vertical"?p.width/cal.vPieces:p.width):(cal.type=="vertical"?p.width/cal.vPieces*cal.scaleX:p.width*cal.scaleX),
								height:withCSS3()?(cal.type=="vertical"?p.height:p.height/cal.hPieces):(p.type=="vertical"?p.height*cal.scaleY:p.height/cal.hPieces*cal.scaleY),
								position:"absolute",
								left:cal.type=="vertical"?(p.width+cal.xOffset*2)/cal.vPieces*si-cal.xOffset:cal.xOffset-cal.xOffset*2/cal.hPieces*si,
								top:cal.type=="vertical"?cal.yOffset:(p.height+cal.yOffset*2)/cal.hPieces*si-cal.yOffset,
								"background-image":bgSource,
								backgroundPosition: cal.type=="vertical"?-p.width/cal.vPieces*si+"px top":"left "+-p.height/cal.hPieces*si+"px"
							})
							.csTransform({
								transform: !cal.rotateSymmetric?"rotate("+(-cal.rotate+cal.rotate*2*(si+1)/cal.vPieces)+"deg) scaleY("+cal.scaleY+") scaleX("+cal.scaleX+") translate("+cal.translateX+"px,"+cal.translateY+"px)":"rotate("+cal.rotate+"deg) scaleY("+cal.scaleY+") scaleX("+cal.scaleX+") translate("+cal.translateX+"px,"+cal.translateY+"px)",
								delay:0,
								time:0,
								ease:cal.ease,
								origin:cal.origin,
								animateOrigin:cal.animateOrigin
							})
							cal.initSliceWidth = p.width/cal.vPieces
							cal.initSliceHeight = p.height/cal.hPieces
						})
					}
					if(callback) {
						setTimeout(function(){callback()},20)
					}
				}
				this.setTo=function(calSet,time,callback) {
					var d={}
					$.extend(d,calSet);
					$.extend(cal,calSet);
					if(time) cal.dur = time;
					
					if(cal.type == "multi") {
						var fDummy = this.loader().find(".csChopper-dummy")
						fDummy.children("div").each(function(){
							$(this).children("div").each(function(){
								var si = $(this).parent().index()
								var si2 = $(this).index()
								if (!withCSS3()) var animateProps = {
									left:(cal.width+cal.xOffset*2)/cal.vPieces*si2-cal.xOffset,
									top:cal.yOffset*2*si/cal.hPieces - cal.yOffset,
									width:cal.scaleX*cal.initSliceWidth,
									height:cal.scaleY*cal.initSliceHeight
								};
								else animateProps = {
									left:(cal.width+cal.xOffset*2)/cal.vPieces*si2-cal.xOffset,
									top:cal.yOffset*2*si/cal.hPieces - cal.yOffset
								};
								var rotateAngle = !cal.rotateSymmetric?-(-cal.rotate+cal.rotate*2*(si2+1)/cal.vPieces ):cal.rotate;
								
								$(this).csTransform({
									transform: "rotate("+rotateAngle+"deg) scaleY("+cal.scaleY+") scaleX("+cal.scaleX+") translate("+cal.translateX+"px,"+cal.translateY+"px)",
									delay:(si*cal.vPieces/5+si2)*cal.pieceDelay,
									time:cal.dur,
									ease:cal.ease,
									origin:cal.origin,
									animateOrigin:cal.animateOrigin
								})
								.delay((si*cal.vPieces/5+si2)*cal.pieceDelay)
								.animate(animateProps,cal.dur,function(){
									if (callback&&((si2+1)*(si+1) == cal.hPieces*cal.vPieces)) callback();
									if (d.completeEach) d.completeEach();
									if (d.completeFirst&&si==0&&si2==0) d.completeFirst();
								})
							})
						})
					}
					else {
						var fDummy = this.loader().find(".csChopper-dummy")
						fDummy.children("div").each(function(){
								var si = $(this).index()
								if (d.onStart && si==0) d.onStart();
								if (!withCSS3()) var animateProps = {
									left:cal.type=="vertical"?(cal.width+cal.xOffset*2)/cal.vPieces*si-cal.xOffset:cal.xOffset-cal.xOffset*2/cal.hPieces*si,
									top:cal.type=="vertical"?cal.yOffset:(cal.height+cal.yOffset*2)/cal.hPieces*si-cal.yOffset,
									width:cal.scaleX*cal.initSliceWidth,
									height:cal.scaleY*cal.initSliceHeight
								};
								else var animateProps = {
									left:cal.type=="vertical"?(cal.width+cal.xOffset*2)/cal.vPieces*si-cal.xOffset:cal.xOffset-cal.xOffset*2/cal.hPieces*si,
									top:cal.type=="vertical"?cal.yOffset:(cal.height+cal.yOffset*2)/cal.hPieces*si-cal.yOffset
								};
								$(this).csTransform({
									transform: !cal.rotateSymmetric?"rotate("+(-cal.rotate+cal.rotate*2*(si+1)/cal.vPieces)+"deg) scaleY("+cal.scaleY+") scaleX("+cal.scaleX+") translate("+cal.translateX+"px,"+cal.translateY+"px)":"rotate("+cal.rotate+"deg) scaleY("+cal.scaleY+") scaleX("+cal.scaleX+") translate("+cal.translateX+"px,"+cal.translateY+"px)",
									delay:cal.pieceDelay*si,
									time:cal.dur,
									ease:cal.ease,
									origin:cal.origin,
									animateOrigin:cal.animateOrigin
								})
								.delay(cal.pieceDelay*si)
								.animate(animateProps,{duration:cal.dur,complete : function(){
									if (callback&&$(this).index()==(cal.type=="vertical"?cal.vPieces-1:cal.hPieces-1)) {
													callback();
									}
									if (d.completeEach) d.completeEach();
									if (d.completeFirst&&$(this).index()==0) d.completeFirst();
									if (d.completeNth&&$(this).index()==d.completeNth.index) d.completeNth.complete();
								}})
						})
					}
				}
				this.fadeTo = function(ft,time,callback) {
					ft.dur = time>=0?time:300;
					ft.pieceDelay = ft.pieceDelay>=0?ft.pieceDelay:cal.pieceDelay;
					var fDummy = this.loader().children("div:last")
					fDummy.clone().appendTo(loader)
					var newBgSource;
					var srcObj = $(ft.image);
					if(srcObj.length>0) {
						if(srcObj.attr("src")) newBgSource = "url("+srcObj.attr("src")+")";
						if(srcObj.css("background-image").indexOf("rl")>=0) newBgSource = srcObj.css("background-image")
					}
					else newBgSource = "url("+ft.image+")";
					
					if(cal.type == "multi") {
						this.loader().children("div:eq(1)").children("div").each(function(){
							$(this).find("div").each(function(){
								var si = $(this).parent().index()
								var si2 = $(this).index()
								fDummy.children("div:eq("+si+")").find("div:eq("+si2+")")
								.delay((si*cal.vPieces/5+si2)*ft.pieceDelay).fadeOut(ft.dur)
								$(this).css({
									display:"none",
									"background-image":newBgSource
								}).delay(($(this).parent().index()*cal.vPieces/5+$(this).index())*ft.pieceDelay).fadeIn(ft.dur,function(){
									fDummy.children("div:eq("+$(this).parent().index()+")").find("div:eq("+$(this).index()+")").hide()
									if($(this).index()*$(this).parent().index()==(cal.hPieces-1)*(cal.vPieces-1)) {
										fDummy.remove()	
										if(callback) callback()
									}
								})	
							})
											
						})

					}
					else {
						this.loader().children("div:eq(1)").find("div").each(function(){
								fDummy.find("div:eq("+$(this).index()+")").delay(ft.pieceDelay*$(this).index()).fadeOut(ft.dur)
								$(this).css({
									display:"none",
									"background-image":newBgSource
								}).delay(ft.pieceDelay*$(this).index()).fadeIn(ft.dur,function(){
									fDummy.find("div:eq("+$(this).index()+")").hide()
									if($(this).index()==(cal.type=="vertical"?cal.vPieces-1:cal.hPieces-1)) {
										fDummy.remove()	
										if(callback) callback()
									}
								})
						})
					}
				}
				this.fadeToSet = function(fts,time,callback) {
					var d={};
					var dd = {};
					$.extend(dd,cal);
					$.extend(d,fts);
					$.extend(cal,fts);
					if(time) cal.dur = time;
					if(!cal.fadeDur) cal.fadeDur = 900;
					var fDummy = this.loader().children("div:last")
					fDummy.clone().appendTo(loader)
					var newBgSource;
					var srcObj = $(d.image);
					if(srcObj.length>0) {
							if(srcObj.attr("src")) newBgSource = "url("+srcObj.attr("src")+")";
							if(srcObj.css("background-image").indexOf("rl")>=0) newBgSource = srcObj.css("background-image")
					}
					else newBgSource = "url("+ft.image+")";
					
					if(cal.type == "multi") {
						this.loader().children("div:last").children("div").each(function(){
							$(this).find("div").each(function(){
								var si = $(this).parent().index()
								var si2 = $(this).index()
								var rotateAngle = !dd.rotateSymmetric?-(-dd.rotate+dd.rotate*2*(si2+1)/dd.vPieces ):dd.rotate;
								if(d.xFade)fDummy.children("div:eq("+si+")").find("div:eq("+si2+")").fadeOut(cal.fadeDur)
								$(this).css({
									display:"none",
									"background-image":newBgSource,
									left:(p.width+dd.xOffset*2)/p.vPieces*si2-dd.xOffset,
									top:dd.yOffset*2*si/p.hPieces - dd.yOffset,
									width:!withCSS3()?dd.scaleX*cal.initSliceWidth:$(this).width(),
									height:!withCSS3()?dd.scaleY*cal.initSliceHeight:$(this).height()
								})
								.csTransform({
										transform: "rotate("+rotateAngle+"deg) scaleY("+dd.scaleY+") scaleX("+dd.scaleX+") translate("+dd.translateX+"px,"+dd.translateY+"px)",
										delay:0,
										time:0,
										ease:dd.ease,
										origin:dd.origin,
										animateOrigin:dd.animateOrigin
								})
								.delay((si*cal.vPieces/5+si2)*cal.pieceDelay).fadeIn(cal.fadeDur,function(){
									fDummy.children("div:eq("+si+")").find("div:eq("+si2+")").hide()
									if($(this).index()*$(this).parent().index()==(cal.hPieces-1)*(cal.vPieces-1)) {
										fDummy.remove()	
									}
									if (!withCSS3()) var animateProps = {
										left:(cal.width+cal.xOffset*2)/cal.vPieces*si2-cal.xOffset,
										top:cal.yOffset*2*si/cal.hPieces - cal.yOffset,
										width:cal.scaleX*cal.initSliceWidth,
										height:cal.scaleY*cal.initSliceHeight
									};
									else animateProps = {
										left:(cal.width+cal.xOffset*2)/cal.vPieces*si2-cal.xOffset,
										top:cal.yOffset*2*si/cal.hPieces - cal.yOffset
									};
									var rotateAngle = !cal.rotateSymmetric?-(-cal.rotate+cal.rotate*2*(si2+1)/cal.vPieces ):cal.rotate;
									$(this).csTransform({
										transform: "rotate("+rotateAngle+"deg) scaleY("+cal.scaleY+") scaleX("+cal.scaleX+") translate("+cal.translateX+"px,"+cal.translateY+"px)",
										time:cal.dur,
										ease:cal.ease,
										origin:cal.origin,
										animateOrigin:cal.animateOrigin,
										delay:0
									})
									.animate(animateProps,cal.dur,function(){
										if (callback&&((si2+1)*(si+1) == cal.hPieces*cal.vPieces)) callback();
										if (d.completeEach) d.completeEach();
										if (d.completeFirst&&si==0&&si2==0) d.completeFirst();
														
									})
								})	
							})
						})
					}
					else {
						this.loader().children("div:last").find("div").each(function(){
								
								var si = $(this).index()
								var rotateAngle = !dd.rotateSymmetric?(-dd.rotate+dd.rotate*2*(si+1)/cal.vPieces):dd.rotate;
								if(d.xFade) fDummy.find("div:eq("+$(this).index()+")").fadeOut(cal.fadeDur)
								$(this).css({
									display:"none",
									"background-image":newBgSource,
									left:cal.type=="vertical"?(cal.width+dd.xOffset*2)/cal.vPieces*si-dd.xOffset:dd.xOffset-dd.xOffset*2/cal.hPieces*si,
									top:cal.type=="vertical"?dd.yOffset:(cal.height+dd.yOffset*2)/cal.hPieces*si-dd.yOffset,
									width:!withCSS3()?dd.scaleX*cal.initSliceWidth:$(this).width(),
									height:!withCSS3()?dd.scaleY*cal.initSliceHeight:$(this).height()
								})
								.csTransform({
										transform: "rotate("+rotateAngle+"deg) scaleY("+dd.scaleY+") scaleX("+dd.scaleX+") translate("+dd.translateX+"px,"+dd.translateY+"px)",
										delay:0,
										time:0,
										ease:dd.ease,
										origin:dd.origin,
										animateOrigin:dd.animateOrigin
								})
								.delay(cal.pieceDelay*$(this).index()).fadeIn(cal.fadeDur,function(){
									fDummy.find("div:eq("+$(this).index()+")").hide()
									if($(this).index()==(cal.type=="vertical"?cal.vPieces-1:cal.hPieces-1)) {
										fDummy.remove()	
									}
									if (!withCSS3()) var animateProps = {
										left:cal.type=="vertical"?(cal.width+cal.xOffset*2)/cal.vPieces*si-cal.xOffset:cal.xOffset-cal.xOffset*2/cal.hPieces*si,
										top:cal.type=="vertical"?cal.yOffset:(cal.height+cal.yOffset*2)/cal.hPieces*si-cal.yOffset,
										width:cal.scaleX*cal.initSliceWidth,
										height:cal.scaleY*cal.initSliceHeight
									};
									else animateProps = {
										left:cal.type=="vertical"?(cal.width+cal.xOffset*2)/cal.vPieces*si-cal.xOffset:cal.xOffset-cal.xOffset*2/cal.hPieces*si,
										top:cal.type=="vertical"?cal.yOffset:(cal.height+cal.yOffset*2)/cal.hPieces*si-cal.yOffset
									};
									var rotateAngle = !cal.rotateSymmetric?-(cal.rotate+cal.rotate*2*(si+1)/cal.vPieces):cal.rotate;
									$(this).csTransform({
										transform: "rotate("+rotateAngle+"deg) scaleY("+cal.scaleY+") scaleX("+cal.scaleX+") translate("+cal.translateX+"px,"+cal.translateY+"px)",
										time:cal.dur,
										ease:cal.ease,
										origin:cal.origin,
										animateOrigin:cal.animateOrigin,
										delay:0
									})
									.animate(animateProps,cal.dur,function(){
										if (callback&&$(this).index()==(cal.type=="vertical"?cal.vPieces-1:cal.hPieces-1)) {
											callback();
										}
										if (d.completeEach) d.completeEach();
										if (d.completeFirst&&$(this).index()==0) d.completeFirst();
										if (d.completeNth&&$(this).index()==d.completeNth.index) d.completeNth.complete();
														
									})
								})	
						})
					}
				}
			}
			
			function chopIt(p) {
				
				switch (p.type) {
				case "multi" : {
					
					var fDummy = loader.find(".csChopper-dummy")
					for (var i=1;i<=p.hPieces;i++) {
						fDummy.append('<div ></div>')
					}
					fDummy.children("div").each(function(){
						for (var i=1;i<=p.vPieces;i++) {
							$(this).append('<div></div>')
						}
					})
					if(!p.hidden) loader.show()
					
					var chopCallbacks = new Callbacks(p,loader.attr("data-csid"));
					if(p.onStart) {p.onStart(chopCallbacks);p.onStart=false;}
					fDummy.children("div").each(function(){
						var si = $(this).index()
						$(this).css({
							width:p.width,
							position:"absolute",
							top:p.height/p.hPieces*si,
							left:0,
							height:p.height/p.hPieces
						})
						.find("div").each(function(){
							var si = $(this).parent().index()
							var si2 = $(this).index()
							$(this).css({
								width:p.width/p.vPieces,
								position:"absolute",
								top:0,
								left:p.width/p.vPieces*si2,
								height:p.height/p.hPieces,
								"background-image":bgSource,
								backgroundPosition: -p.width/p.vPieces*si2+"px "+-p.height/p.hPieces*si+"px"
							})
							p.initSliceWidth = $(this).width()
							p.initSliceHeight = $(this).height()
							if (!withCSS3()) var animateProps = {
								left:(p.width+p.xOffset*2)/p.vPieces*si2-p.xOffset,
								top:p.yOffset*2*si/p.hPieces - p.yOffset,
								width:p.scaleX*$(this).width(),
								height:p.scaleY*$(this).height()
							};
							else animateProps = {
								left:(p.width+p.xOffset*2)/p.vPieces*si2-p.xOffset,
								top:p.yOffset*2*si/p.hPieces - p.yOffset
							};
							cropFirstSlide(si,si2)
							function cropFirstSlide(index1,index2) {
								setTimeout(function(){
									var rotateAngle = !p.rotateSymmetric?-(-p.rotate+p.rotate*2*(index2+1)/p.vPieces ):p.rotate;
									fDummy.children("div:eq("+index1+")").children("div:eq("+index2+")").csTransform({
											transform: "rotate("+rotateAngle+"deg) scaleY("+p.scaleY+") scaleX("+p.scaleX+") translate("+p.translateX+"px,"+p.translateY+"px)",
											delay:(index1*p.vPieces/5+index2)*p.pieceDelay,
											time:p.dur,
											ease:p.ease,
											origin:p.origin,
											animateOrigin:p.animateOrigin
									})
								},0)
							}
							$(this)
							.delay((si*p.vPieces/5+si2)*p.pieceDelay)
							.animate(animateProps,p.dur,function(){
								if (p.completeEach) p.completeEach(chopCallbacks);
								if (p.completeFirst&&$(this).index()==0&&$(this).parent().index()==0) p.completeFirst(chopCallbacks);
								if (callback&&(($(this).index()+1)*($(this).parent().index()+1) == p.hPieces*p.vPieces)) callback(chopCallbacks);
							})
						})
					})
				};
				break;
				default : {
					var fDummy = loader.find(".csChopper-dummy")
					for (var i=1;i<=(p.type=="vertical"?p.vPieces:p.hPieces);i++) {
						fDummy.append('<div ></div>')
					}
					if(!p.hidden) loader.show()
					var chopCallbacks = new Callbacks(p,loader.attr("data-csid"));
					if(p.onStart) {p.onStart(chopCallbacks);p.onStart=false;}
					
					fDummy.children("div").each(function(){
						var si = $(this).index()
						$(this).css({
							width:p.type=="vertical"?p.width/p.vPieces:p.width,
							position:"absolute",
							top:p.type=="vertical"?0:p.height/p.hPieces*si,
							left:p.type=="vertical"?p.width/p.vPieces*si:0,
							height:p.type=="vertical"?p.height:p.height/p.hPieces,
							"background-image":bgSource,
							backgroundPosition: p.type=="vertical"?-p.width/p.vPieces*si+"px top":"left "+-p.height/p.hPieces*si+"px"
						})
						p.initSliceWidth = $(this).width()
						p.initSliceHeight = $(this).height()
						if (!withCSS3()) var animateProps = {
								left:p.type=="vertical"?(p.width+p.xOffset*2)/p.vPieces*si-p.xOffset:p.xOffset-p.xOffset*2/p.hPieces*si,
								top:p.type=="vertical"?p.yOffset:(p.height+p.yOffset*2)/p.hPieces*si-p.yOffset,
								width:p.scaleX*$(this).width(),
								height:p.scaleY*$(this).height()
						};
						else var animateProps = {
								left:p.type=="vertical"?(p.width+p.xOffset*2)/p.vPieces*si-p.xOffset:p.xOffset-p.xOffset*2/p.hPieces*si,
								top:p.type=="vertical"?p.yOffset:(p.height+p.yOffset*2)/p.hPieces*si-p.yOffset
						};
						$(this).csTransform({
								transform: !p.rotateSymmetric?"rotate("+(-p.rotate+p.rotate*2*(si+1)/p.vPieces)+"deg) scaleY("+p.scaleY+") scaleX("+p.scaleX+") translate("+p.translateX+"px,"+p.translateY+"px)":"rotate("+p.rotate+"deg) scaleY("+p.scaleY+") scaleX("+p.scaleX+") translate("+p.translateX+"px,"+p.translateY+"px)",
								delay:p.pieceDelay*si,
								time:p.dur,
								ease:p.ease,
								origin:p.origin,
								animateOrigin:p.animateOrigin
						})
						.delay(p.pieceDelay*si)
						.animate(animateProps,{duration:p.dur,complete:function(){
							
							if (callback&&$(this).index()==(p.type=="vertical"?p.vPieces-1:p.hPieces-1)) {
									callback(chopCallbacks);
							};
							if (p.completeEach) p.completeEach(chopCallbacks);
							if (p.completeFirst&&$(this).index()==0) p.completeFirst(chopCallbacks);
							if (p.completeNth&&$(this).index()==p.completeNth.index) p.completeNth.complete(chopCallbacks);
						}})
					})		
				};
				break;
				}
			};
		})/* End of return.each */
		}
		
	})(jQuery);
	
	
	/*  ------------------------  Only Slider's Code ----------------------------- */
	if(this.length==0) return;
	
	$.chopSlider.animation = 0;
	var slider = {};
	var container = this;
	slider.loader = $(a.loader);
	slider.loader.html('<div class="dummy-blocks" style="position:relative"><div class="dummy-first"></div><div class="dummy-last" style="display:none;position:absolute;left:0px;top:0px;"></div></div>')
	var slide = a.slide || ".slide";
	a.width = container.width();
	a.height = container.height()
	
	/* Custom Slide Function */
	
	$.chopSlider.slide = function(b){
	   if(!b) {b = a; c = b}
	   else {
		    c={};
			$.extend(c,a,b);   
	   }
	   if(!b.direction) b.direction = "next";
	   if(c.autoplay==false) clearInterval($.chopSlider.autoplay);
	   else {
			autoPlay();	
	   }
	   chopSlide(b.direction,c)
	}
	
	
	
	/* Autoplay */
	function autoPlay() {
		$.chopSlider.autoplay = setInterval(function(){
			chopSlide("next",a)		
		},a.autoplayDelay)	
	}
	if(a.autoplay) {
		autoPlay();
	}
	
		
	/* Captions */
	
	if(a.useCaptions) {
		var newDescr = $(a.everyCaptionIn).eq($(a.slide+".activeSlide").index()).html();
		if ($.trim(newDescr)!="") {
			$(a.showCaptionIn).show().html(newDescr)
		}
	}
	
	$.chopSlider.hideDescr = function(){
		$(a.showCaptionIn).hide()
		.csTransform({transform:a.captionTransform,time:300,delay:0})
	}
	$.chopSlider.showDescr = function(){
		var newDescr = $(a.everyCaptionIn).eq($(a.slide+".activeSlide").index()).html();
		if ($.trim(newDescr)=="") return;
		$(a.showCaptionIn).html(newDescr)
		$(a.showCaptionIn).fadeIn(300,function(){
			$(this).csTransform({transform:"scale(1,1) translate(0px,0px) rotate(0deg)",time:600,delay:0})
		})
		
	}
	
	/*Slider Position*/
	
	slider.loader.css({
		left:container.offset().left,
		top:container.offset().top,
		position:"absolute",
		"z-index":a.loaderIndex>=0?a.loaderIndex:20000,
		width:a.width,
		height:a.height,
		display:"none"
	})
	$(window).resize(function(){
		slider.loader.css({
			left:container.offset().left,
			top:container.offset().top
		})
	})
	
	/*Slide Triggers*/
	
	slider.nextTrigger = $(a.nextTrigger);
	slider.prevTrigger = $(a.prevTrigger);
	
	slider.nextTrigger.click(function(e){
		clearInterval($.chopSlider.autoplay)
		e.preventDefault();
		chopSlide("next",a,"full");
	})
	slider.prevTrigger.click(function(e){
		clearInterval($.chopSlider.autoplay)
		e.preventDefault();
		chopSlide("prev",a,"full");
	})
	
	/* Chop Slide Function */
	
	function chopSlide(direction,f) {
		
		if((f.prevTransition && direction=="prev")||f.random) {
			var defaultVars = {};
			$.extend(defaultVars,f);
		}
		
		if(f.noCSS3&&!$.chopSlider.hasCSS3()) {
				if (f.noCSS3.scaleY||f.noCSS3.scaleY===0) f.scaleY = f.noCSS3.scaleY;
				if (f.noCSS3.scaleX||f.noCSS3.scaleX===0) f.scaleX = f.noCSS3.scaleX;
				if (f.noCSS3.translateY||f.noCSS3.translateY===0) f.translateY = f.noCSS3.translateY;
				if (f.noCSS3.translateX||f.noCSS3.translateX===0) f.translateX = f.noCSS3.translateX;
				if (f.noCSS3.rotate||f.noCSS3.rotate===0) f.rotate = f.noCSS3.rotate;	
				if (f.noCSS3.xOffset||f.noCSS3.xOffset===0) f.xOffset = f.noCSS3.xOffset;
				if (f.noCSS3.yOffset||f.noCSS3.yOffset===0) f.yOffset = f.noCSS3.yOffset;
				if (f.noCSS3.hPieces) f.hPieces = f.noCSS3.hPieces;
				if (f.noCSS3.vPieces) f.vPieces = f.noCSS3.vPieces;
				if (f.noCSS3.type) f.type = f.noCSS3.type;
				if (f.noCSS3.rotateSymmetric===true||f.noCSS3.rotateSymmetric===false) f.rotateSymmetric = f.noCSS3.rotateSymmetric;
				if (f.noCSS3.pieceDelay||f.noCSS3.pieceDelay===0) f.pieceDelay = f.noCSS3.pieceDelay;
				if (f.noCSS3.xFadeDelay||f.noCSS3.xFadeDelay===0) f.xFadeDelay = f.noCSS3.xFadeDelay;
				if (f.noCSS3.dur1>=0) f.dur1 = f.noCSS3.dur1;
				if (f.noCSS3.dur2>=0) f.dur2 = f.noCSS3.dur2;
				if (f.noCSS3.dur3>=0) f.dur3 = f.noCSS3.dur3;
				if (f.noCSS3.onStart) f.onStart = f.noCSS3.onStart;
				if (f.noCSS3.onEnd) f.onEnd = f.noCSS3.onEnd;
		}
		if(f.mobile) {
			if(isMobile()) {
				if (f.mobile.scaleY||f.mobile.scaleY===0) f.scaleY = f.mobile.scaleY;
				if (f.mobile.scaleX||f.mobile.scaleX===0) f.scaleX = f.mobile.scaleX;
				if (f.mobile.translateY||f.mobile.translateY===0) f.translateY = f.mobile.translateY;
				if (f.mobile.translateX||f.mobile.translateX===0) f.translateX = f.mobile.translateX;
				if (f.mobile.rotate||f.mobile.rotate===0) f.rotate = f.mobile.rotate;	
				if (f.mobile.xOffset||f.mobile.xOffset===0) f.xOffset = f.mobile.xOffset;
				if (f.mobile.yOffset||f.mobile.yOffset===0) f.yOffset = f.mobile.yOffset;
				if (f.mobile.hPieces) f.hPieces = f.mobile.hPieces;
				if (f.mobile.vPieces) f.vPieces = f.mobile.vPieces;
				if (f.mobile.type) f.type = f.mobile.type;
				if (f.mobile.disableCSS3) f.disableCSS3 = f.mobile.disableCSS3;
				if (f.mobile.rotateSymmetric===true||f.mobile.rotateSymmetric===false) f.rotateSymmetric = f.mobile.rotateSymmetric;
				if (f.mobile.pieceDelay||f.mobile.pieceDelay===0) f.pieceDelay = f.mobile.pieceDelay;
				if (f.mobile.xFadeDelay||f.mobile.xFadeDelay===0) f.xFadeDelay = f.mobile.xFadeDelay;
				if (f.mobile.dur1>=0) f.dur1 = f.mobile.dur1;
				if (f.mobile.dur2>=0) f.dur2 = f.mobile.dur2;
				if (f.mobile.dur3>=0) f.dur3 = f.mobile.dur3;
				if (f.mobile.onStart) f.onStart = f.mobile.onStart;
				if (f.mobile.onEnd) f.onEnd = f.mobile.onEnd;
			}
		}
		/* Random Function. Beta! */
			if(f.xOffset=="random") f.xOffset = (Math.round((Math.random()*400))-200);
			if(f.yOffset=="random") f.yOffset = (Math.round((Math.random()*200))-100);
			if(f.rotate=="random") f.rotate = f.rotateSymmetric==false?(Math.round((Math.random()*100))-50):(Math.round((Math.random()*360))-180);
			if(f.scaleX=="random") f.scaleX = (Math.round((Math.random()*100-100)))/100;
			if(f.scaleY=="random") f.scaleY = (Math.round((Math.random()*100-100)))/100;
			
		
		function activateNextSlide(){
			fDummy.html("");
			sDummy.html("");
			if(direction=="next") {
				if($(".activeSlide").next(slide).length>0) {
					$(".activeSlide").removeClass("activeSlide").next(slide).addClass("activeSlide").show();

				}
				else {
					$(".activeSlide").removeClass("activeSlide")
					$(slide+":eq(0)").addClass("activeSlide").show();
				}
			}
			else {
				if($(".activeSlide").prev(slide).length>0) {
					$(".activeSlide").removeClass("activeSlide").prev(slide).addClass("activeSlide").show();
				}
				else {
					$(".activeSlide").removeClass("activeSlide")
					$(slide+":last").addClass("activeSlide").show();
				}
					
			}
			if(f.hideControls) {
				slider.nextTrigger.fadeIn(600);
				slider.prevTrigger.fadeIn(600);	
			}
			slider.loader.hide()
			$.chopSlider.animation = 0;
			if(f.useCaptions) $.chopSlider.showDescr();
			if(f.onEnd) f.onEnd();
			if(f.prevTransition||f.random) $.extend(f,defaultVars);
		}
		
		/* Animation Trigger */
		if($.chopSlider.animation == 1) return;
		$.chopSlider.animation = 1;
		
		/* Onstart functions */
		if(f.hideControls) {
			slider.nextTrigger.hide();
			slider.prevTrigger.hide();	
		}
		if(f.onStart) f.onStart();
		if(f.useCaptions) $.chopSlider.hideDescr();
		
		/* We need to determine next (or prev) slide */
		var activeSlide = $(slide+".activeSlide")
		if(direction=="next") {
			var nextSlide = activeSlide.next(slide);
			if (nextSlide.length==0) {
				var nextSlide = $(slide+":eq(0)");
			}
		}
		else {
			var nextSlide = activeSlide.prev(slide);
			if (nextSlide.length==0) {
				var nextSlide = $(slide+":last");
			}
		}
		activeSlide.hide()
		slider.loader.show()
		
		/* Different transition for previos slide */
		if(f.prevTransition && direction=="prev") {
			$.extend(f,f.prevTransition);	
		}
		
		
		/* Main function */
		switch (f.type) {
		case "vertical" : {
				var fDummy = slider.loader.find(".dummy-first")
				var sDummy = slider.loader.find(".dummy-last")
				for (var i=1;i<=f.vPieces;i++) {
					fDummy.append('<div ></div>')	
					sDummy.append('<div ></div>')	
				}
				setTimeout(function(){
					sDummy.show()
				},f.dur1)
				fDummy.children("div").each(function(){
					var si = $(this).index()
					
					$(this).css({
						width:f.width/f.vPieces,
						position:"absolute",
						top:0,
						left:f.width/f.vPieces*si,
						height:f.height,
						"background-image":"url("+activeSlide.find("img").attr("src")+")",
						backgroundPosition: -f.width/f.vPieces*si+"px top"
					})
					if (!withCSS3()) var animateProps = {
							left:(f.width+f.xOffset*2)/f.vPieces*si-f.xOffset,
							top:f.yOffset,
							width:f.scaleX*$(this).width(),
							height:f.scaleY*$(this).height()
					};
					else var animateProps = {
							left:(f.width+f.xOffset*2)/f.vPieces*si-f.xOffset,
							top:f.yOffset
					};
					$(this).csTransform({
							transform: "rotate(0deg) scaleY(1) scaleX(1) translate(0px,0px)",
							delay:0,
							time:0,
							ease:f.ease1,
							origin:f.origin
					})
					.delay(f.pieceDelay*si)
					.animate(animateProps,f.dur1,function(){
						var newTransform = !f.rotateSymmetric?"rotate("+(-f.rotate+f.rotate*2*($(this).index()+1)/f.vPieces)+"deg) scaleY("+f.scaleY+") scaleX("+f.scaleX+") translate("+f.translateX+"px,"+f.translateY+"px)":"rotate("+f.rotate+"deg) scaleY("+f.scaleY+") scaleX("+f.scaleX+") translate("+f.translateX+"px,"+f.translateY+"px)";
						
						if (!withCSS3()) var animateProps2 = {
								left:f.width/f.vPieces*si,
								top:0,
								width: withCSS3() ? "auto" : f.width/f.vPieces,
								height: withCSS3() ? "auto" : f.height
						};
						else var animateProps2= {
								left:f.width/f.vPieces*si,
								top:0
						};
						sDummy.find("div:eq("+si+")").csTransform({
							transform: newTransform,
							delay:0,
							time:0,
							ease:f.ease2,
							origin:f.origin
						}).css({
							width:withCSS3() ? f.width/f.vPieces : f.scaleX*f.width/f.vPieces,
							position:"absolute",
							top:f.yOffset,
							left:(f.width+f.xOffset*2)/f.vPieces*si-f.xOffset,
							height:withCSS3() ? f.height : f.scaleY*f.height,
							display:"none",
							"background-image":"url("+nextSlide.find("img").attr("src")+")",
							backgroundPosition: -f.width/f.vPieces*si+"px top"
						}).delay(f.xFadeDelay).fadeIn(f.dur2,function(){
								
								fDummy.children('div:eq('+si+')').hide()
								$(this).csTransform({transform:"rotate(0deg) scaleY(1) scaleX(1) translate(0px,0px)",time:f.dur3,delay:0,
							ease:f.ease2,origin:f.origin})
								
						})
						.animate(animateProps2,f.dur3,function(){
							
							if (($(this).index()+1) == f.vPieces) activateNextSlide();
			
						})
					})
					cropFirstSlide(si)
					function cropFirstSlide(index) {
						setTimeout(function(){
							var newTransform = !f.rotateSymmetric?"rotate("+(-f.rotate+f.rotate*2*(index+1)/f.vPieces)+"deg) scaleY("+f.scaleY+") scaleX("+f.scaleX+") translate("+f.translateX+"px,"+f.translateY+"px)":"rotate("+f.rotate+"deg) scaleY("+f.scaleY+") scaleX("+f.scaleX+") translate("+f.translateX+"px,"+f.translateY+"px)";
							fDummy.children("div:eq("+index+")").csTransform({
								transform: newTransform,
								delay:f.pieceDelay*index,
								time:f.dur1,
								ease:f.ease1,
								origin:f.origin
							})
						},0)
					}
				})
		};
		break;
		case "horizontal" : {

				var fDummy = slider.loader.find(".dummy-first")
				var sDummy = slider.loader.find(".dummy-last").show()
				for (var i=1;i<=f.hPieces;i++) {
					fDummy.append('<div ></div>')	
					sDummy.append('<div ></div>')	
				}
				
				setTimeout(function(){
					sDummy.show()
				},f.dur1)
				
				
				fDummy.children("div").each(function(){
					var si = $(this).index()
					$(this).css({
						width:f.width,
						position:"absolute",
						top:f.height/f.hPieces*si,
						left:0,
						height:f.height/f.hPieces,
						"background-image":"url("+activeSlide.find("img").attr("src")+")",
						backgroundPosition: "left "+-f.height/f.hPieces*si+"px"
					})
					if (!withCSS3()) var animateProps = {
							left:f.xOffset-f.xOffset*2/f.hPieces*si,
							top:(f.height+f.yOffset*2)/f.hPieces*si-f.yOffset,
							width:f.scaleX*$(this).width(),
							height:f.scaleY*$(this).height()
					};
					else animateProps = {
							left:f.xOffset-f.xOffset*2/f.hPieces*si,
							top:(f.height+f.yOffset*2)/f.hPieces*si-f.yOffset
					};
					$(this).csTransform({
							transform: "rotate(0deg) scaleY(1) scaleX(1) translate(0px,0px)",
							delay:0,
							time:0,
							ease:f.ease1,
							origin:f.origin
					})
					.delay(f.pieceDelay*si)
					.animate(animateProps,f.dur1,function(){
						sDummy.children('div:eq('+si+')').css({
							width:withCSS3() ? f.width : f.scaleX*f.width,
							position:"absolute",
							top:(f.height+f.yOffset*2)/f.hPieces*si-f.yOffset,
							left:f.xOffset-f.xOffset*2/f.hPieces*si,
							height:withCSS3() ? f.height/f.hPieces : f.scaleY*f.height/f.hPieces,
							display:"none",
							"background-image":"url("+nextSlide.find("img").attr("src")+")",
							backgroundPosition: "left "+-f.height/f.hPieces*si+"px"
						})
						var newTransform=!f.rotateSymmetric?"rotate("+(-f.rotate+f.rotate*2*($(this).index()+1)/f.hPieces)+"deg) scaleY("+f.scaleY+") scaleX("+f.scaleX+") translate("+f.translateX+"px,"+f.translateY+"px)":"rotate("+f.rotate+"deg) scaleY("+f.scaleY+") scaleX("+f.scaleX+") translate("+f.translateX+"px,"+f.translateY+"px)";
						if (!withCSS3()) var animateProps2 = {
								left:0,
								top:f.height/f.hPieces*si,
								width: f.width,
								height: f.height/f.hPieces
						};
						else var animateProps2= {
								left:0,
								top:f.height/f.hPieces*si
						};
						sDummy.find("div:eq("+si+")").csTransform({
									transform: newTransform,
									delay:0,
									time:0,
									ease:f.ease2,
									origin:f.origin
						})
						.delay(f.xFadeDelay).fadeIn(f.dur2,function(){
								fDummy.children('div:eq('+si+')').hide()
								$(this).csTransform({
									transform:"rotate(0deg) scaleY(1) scaleX(1) translate(0px,0px)",
									time:f.dur3,
									delay:0,
									ease:f.ease2,
									origin:f.origin
								})	
								
							})
						.animate(animateProps2,f.dur3,function(){
							if (($(this).index()+1) == f.hPieces) activateNextSlide()	;

						})
						
					})
					cropFirstSlide(si)
					function cropFirstSlide(index) {
						setTimeout(function(){
							var newTransform = !f.rotateSymmetric? "rotate("+(-f.rotate+f.rotate*2*(index+1)/f.hPieces)+"deg) scaleY("+f.scaleY+") scaleX("+f.scaleX+") translate("+f.translateX+"px,"+f.translateY+"px)" : "rotate("+f.rotate+"deg) scaleY("+f.scaleY+") scaleX("+f.scaleX+") translate("+f.translateX+"px,"+f.translateY+"px)";
							
							fDummy.children("div:eq("+index+")").csTransform({
								transform: newTransform,
								delay:f.pieceDelay*index,
								time:f.dur1,
								ease:f.ease1,
								origin:f.origin
							})
						},0)
					}
				})
		}
		break;
		case "multi" : {
				var fDummy = slider.loader.find(".dummy-first")
				var sDummy = slider.loader.find(".dummy-last").show()
				for (var i=1;i<=f.hPieces;i++) {
					fDummy.append('<div ></div>')	
					sDummy.append('<div ></div>')	
				}
				setTimeout(function(){
					sDummy.show()
				},f.dur1)
				fDummy.children("div").each(function(){
					var si = $(this).index()
					sDummy.children('div:eq('+si+')').css({
						width:f.width,
						position:"absolute",
						top:f.height/f.hPieces*si,
						left:0,
						height:f.height/f.hPieces
					})
					for (var i=1;i<=f.vPieces;i++) {
						$(this).append('<div ></div>')
						sDummy.children("div:eq("+si+")").append('<div style="display:none;" ></div>')	
					}
					$(this).find("div").each(function(){
						var si = $(this).parent().index()
						var si2 = $(this).index()
						sDummy.children("div:eq("+si+")").find("div:eq("+si2+")").css({
							width:withCSS3() ? f.width/f.vPieces : f.scaleX*f.width/f.vPieces ,
							position:"absolute",
							top:f.yOffset*2*si/f.hPieces - f.yOffset,
							left:(f.width+f.xOffset*2)/f.vPieces*si2-f.xOffset,
							height:withCSS3() ? f.height/f.hPieces : f.scaleY*f.height/f.hPieces,
							"background-image":"url("+nextSlide.find("img").attr("src")+")",
							backgroundPosition: -f.width/f.vPieces*si2+"px "+-f.height/f.hPieces*si+"px"
						})
						$(this).css({
							width:f.width/f.vPieces,
							position:"absolute",
							top:0,
							left:f.width/f.vPieces*si2,
							height:f.height/f.hPieces,
							"background-image":"url("+activeSlide.find("img").attr("src")+")",
							backgroundPosition: -f.width/f.vPieces*si2+"px "+-f.height/f.hPieces*si+"px"
						})
						if (!withCSS3()) var animateProps = {
							left:(f.width+f.xOffset*2)/f.vPieces*si2-f.xOffset,
							top:f.yOffset*2*si/f.hPieces - f.yOffset,
							width:f.scaleX*$(this).width(),
							height:f.scaleY*$(this).height()
						};
						else animateProps = {
							left:(f.width+f.xOffset*2)/f.vPieces*si2-f.xOffset,
							top:f.yOffset*2*si/f.hPieces - f.yOffset
						};
						$(this).csTransform({
							transform: "rotate(0deg) scaleY(1) scaleX(1) translate(0px,0px)",
							delay:0,
							time:0,
							ease:f.ease1,
							origin:f.origin
						}).delay((si*f.vPieces/5+si2)*f.pieceDelay)
						.animate(animateProps,f.dur1,function(){
							if (!withCSS3()) var animateProps2 = {
								left:f.width/f.vPieces*si2,
								top:0,
								width: f.width/f.vPieces,
								height: f.height/f.hPieces
							};
							else var animateProps2= {
								left:f.width/f.vPieces*si2,
								top:0
							};
							var rotateAngle = !f.rotateSymmetric?-(-f.rotate+f.rotate*2*(si2+1)/f.vPieces ):f.rotate;
							sDummy.children("div:eq("+si+")").find("div:eq("+si2+")").csTransform({
										transform: "rotate("+rotateAngle+"deg) scaleY("+f.scaleY+") scaleX("+f.scaleX+") translate("+f.translateX+"px,"+f.translateY+"px)",
										delay:0,
										time:0,
										ease:f.ease2,
										origin:f.origin
							})
							.delay(f.xFadeDelay).fadeIn(f.dur2,function(){
									fDummy.children('div:eq('+si+')').find("div:eq("+si2+")").hide()
									$(this).csTransform({transform:"rotate(0deg) scaleY(1) scaleX(1) translate(0px,0px)",time:f.dur3,delay:0,
										ease:f.ease2,origin:f.origin})	
								})
							.animate(animateProps2,f.dur3,function(){
								if (($(this).index()+1)*($(this).parent().index()+1) == f.hPieces*f.vPieces) activateNextSlide()	;
							})
							
						})
						cropFirstSlide(si,si2)
						function cropFirstSlide(index1,index2) {
							setTimeout(function(){
								var rotateAngle = !f.rotateSymmetric?-(-f.rotate+f.rotate*2*(index2+1)/f.vPieces ):f.rotate;
								fDummy.children("div:eq("+index1+")").children("div:eq("+index2+")").csTransform({
										transform: "rotate("+rotateAngle+"deg) scaleY("+f.scaleY+") scaleX("+f.scaleX+") translate("+f.translateX+"px,"+f.translateY+"px)",
										delay:(index1*f.vPieces/5+index2)*f.pieceDelay,
										time:f.dur1,ease:f.ease1,origin:f.origin
								})
							},0)
						}
					})
					$(this).css({
						width:f.width,
						position:"absolute",
						top:f.height/f.hPieces*si,
						left:0,
						height:f.height/f.hPieces
					})
				})
		}
		break;
		}
	}
	
	
}
})(jQuery);
