$(function(){
	
	$("#slider").chopSlider({
		loader : "#slide-loader",
		loaderIndex : 20000,
		slide : ".slide",
		nextTrigger : "a#slide-next",
		prevTrigger : "a#slide-prev",
		useCaptions : true,
		everyCaptionIn : ".sl-descr",
		showCaptionIn : ".caption",
		captionTransform : "scale(0) translate(-600px,0px) rotate(45deg)",
		type: "multi",
		disableCSS3 : false,
		xOffset: 20,
		yOffset: 20,
		hPieces : 10,
		vPieces: 10,
		rotate : 0 ,
		rotateSymmetric: false,
		scaleX:1,
		scaleY:1,
		translateX:0,
		translateY:0,
		ease1:"ease-in",
		ease2:"ease-out",
		origin:"center center",
		dur1: 1000,
		dur2 :600,
		dur3: 1000,
		pieceDelay : 50,
		xFadeDelay :0,
		autoplay:false,
		autoplayDelay:6000,
		hideControls:true,
		random:true,
		onStart: function(){},
		onEnd: function(){},
		prevTransition : {
			rotate:-180
			
		},
		mobile: {
			disableCSS3:true,
			dur1:1200,
			dur2:1200,
			dur3:1200,
			hPieces:4,
			vPieces:4,
			pieceDelay:120,
			xOffset:"random",
			rotate:10,
			yOffset:0,
			scaleX:1,
			scaleY:1
		},
		noCSS3:{
			dur1:1200,
			dur2:1200,
			dur3:1200,
			hPieces:5,
			vPieces:5,
			pieceDelay:120,
			xFadeDelay :200
		}
	});
	
	
	$(".tw-link img").mouseover(function(){
		$(this).csChop({pieceDelay:20,ease:"ease-in-out",hPieces:29,vPieces:29,type:"horizontal",rotate:360,rotateSymmetric:true,origin:"center center",onStart:function(c){
				c.slices().each(function(){
					$(this).html('<a href="'+c.src().parent().attr("href")+'" target="_blank" style="display:block; width:100%;height:100%"></a>')	
				})
			}},2600,function(a){
				a.reset()
		})	
	})
	$(".fb-link img").mouseover(function(){
		$(this).csChop({pieceDelay:20,ease:"ease-in-out",hPieces:29,vPieces:29,type:"vertical",rotate:-360,rotateSymmetric:true,origin:"center center",onStart:function(c){
				c.slices().each(function(){
					$(this).html('<a href="'+c.src().parent().attr("href")+'" target="_blank" style="display:block; width:100%;height:100%"></a>')	
				})
			}},2500,function(a){
				a.reset()
		})	
	})
	
	$(".demo-icon-1").click(function(){
		$(this).csChop({
			type:"horizontal",
			hPieces:35,
			rotate:360,
			pieceDelay:50,
			rotateSymmetric:true
		},
		3000,
		function(x){
			x.reset()
		})	
	})
	$(".demo-icon-2").mouseover(function(){
		$(this).csChop({
			type:"horizontal",
			hPieces:35,
			rotate:360,
			pieceDelay:50,
			rotateSymmetric:true
		},3000,
		function(x1){
			x1.setTo({rotate:-360,origin:"left top",animateOrigin:true},5000,
				function(){
					x1.reset()
				}
			)
		})	
	})
	$(".demo-icon-3").click(function(){
		$(this).csChop({
			type:"vertical",
			xOffset:20,
			vPieces:35,
			rotate:360,
			pieceDelay:50,
			rotateSymmetric:true,
			origin:"-10px 30px",
			scaleX:1,
			scaleY:1
		},3000,
		function(x2){
			x2.fadeTo({image:".demo-icon-new"},300,function(){
				x2.setBack(2000,function(){
					x2.src().css({visibility:"visible"});
					x2.loader().fadeOut(600,function(){
						x2.reset()
					})
				})
			})
		})	
	})
	$(".demo-icon-4").mouseover(function(){
			$(this).csChop({
				origin:"10px 50%",
				type:"multi",
				hPieces:7,
				vPieces:7,
				xOffset:-90,
				scaleX:-1,
				scaleY:-1,
				yOffset:10,
				rotate:360,
				pieceDelay:50,
				rotateSymmetric:true,
				animateOrigin:true
			},3000,
			function(x3){
				x3.setTo({origin:"5px 50%",rotate:0},1000,function(){
					x3.rows().find("div").each(function(){
					$(this).css("cursor","pointer").hover(function(){$(this).fadeTo(300,0.5)},
						function(){$(this).fadeTo(300,1)});
							$(this).click(function(){
								x3.setBack(2000,function(){
									x3.reset()
								})
							})	
					})
				})
				
			})	
	})
	
	
	
	$(".demo1").click(function(){
		$(this).csChop({
			type: "multi",
			xOffset: 50,
			yOffset: 100,
			hPieces : 10,
			vPieces: 10,
			rotate : 360 ,
			rotateSymmetric: true,
			scaleX:-1,
			scaleY:-1,
			origin:"50px 50%",
			pieceDelay : 80,
			translateX:0,
			translateY:0,
			completeFirst:function(e){
				e.fadeToSet({
					image:".demo2",
					xFade:false,
					pieceDelay:80,
					rotate:180,
					xOffset:50,
					yOffset:50,
					origin:"-50px 50%",
					animateOrigin:true,
					scaleX:-1,
					scaleY:-1,
					fadeDur:900,
					completeFirst:function(){
						e.fadeToSet({image:".demo1",rotate:-360,xOffset:0,yOffset:0,scaleX:1,scaleY:1},6000,function(){
							e.reset()
						})	
					}
				},6000)	
			}
		},3000)	
	})
	
	
	/* ------------- Gallery ---------------*/
	var chopGalleyAnimating = 0;
	$(".gallery-thumbs").click(function(){
		$(".gallery-text").fadeOut(600)
		$(this).csChop(
			{
				type:"multi",
				hPieces:2,
				vPieces:4,
				rotate:360,
				xOffset:-420,
				yOffset:10,
				origin:"200px -50px",
				onStart : function(cs) {
							cs.loader().animate({marginLeft:"+=200px"},3000)
						},
				pieceDelay:100
			},
			3000,
			function(cs){
					initGalleryThumbs(cs);
					showGalSlide(4)
				}	
		)
	})
	function initGalleryThumbs(cs) {
		cs.slices()
		.css({cursor:"pointer"})
		.each(function(){
			$(this).hover(
				function(){
					$(this).csTransform({transform:"rotate(355deg) scale(1.2)",time:500})
				},
				function(){
					$(this).csTransform({transform:"rotate(360deg)  scale(1)",time:500})
				}
			)
			
			$(this).click(function(){
				var sliceIndex = $(this).index();
				var rowIndex = $(this).parent().index();
				var totalIndex = rowIndex==0?(sliceIndex+1):(sliceIndex+5);
				showGalSlide(totalIndex)
					
			})
		})
	}
	function showGalSlide(slideIndex) {
		if(chopGalleyAnimating===1) return;
		chopGalleyAnimating = 1;
		$(".gal-slide-"+slideIndex).csChop(
			{
				hidden:true,
				hPieces:slideIndex%2 ? 15 : 6,
				vPieces:slideIndex%2 ? 20 : 10,
				pieceDelay:0,
				type:slideIndex%2 ? "horizontal" : "multi",
				rotate:slideIndex%2 ? 10 : 180,
				scaleX:slideIndex%2 ? 0 : 0,
				scaleY:slideIndex%2 ? 1: 0,
				xOffset:0,
				yOffset:0,
				origin:slideIndex%2 ? "left top" : "50% 50%",
				rotateSymmetric: slideIndex%2 ? false : true
			},
			10,
			function(cs) {
				cs.loader().show()
				cs.setTo({scaleX:1,scaleY:1,rotate:0,xOffset:0,yOffset:0,pieceDelay:130},2000,function(){
					chopGalleyAnimating = 0;
					$(".gallery-slides img:not(.gal-slide-"+slideIndex+")").each(function(){
						var csid = $(this).attr("data-csid");
						if(csid&&csid!="") {
							$(this).attr({"data-csid":""});
							$(".csChopper[data-csid='"+csid+"']").remove()	
						}
					})	
				})	
			}
		)
		
	}
	
	/*--------------- Generator --------------*/
	$(".g-red").click(function(){
		$(".p-red").csChop(
			{
				type:"multi",
				allowMultiChop : true,
				hPieces:10,
				vPieces:20,
				scaleX:1,
				scaleY:1,
				xOffset:-100,
				yOffset:-50,
				scaleX:0,
				scaleY:0,
				rotate:360,
				origin:"20px -10px",
				hidden:true,
				rotateSymmetric:true
			},
			10,
			function(cs){
				cs.loader().show()
				cs.setTo(
					{
						scaleX:1,
						scaleY:1,
						xOffset:100,
						yOffset:100,
						rotate:0,
						pieceDelay:100,
						completeFirst:function(){
							cs.setTo({
								rotate:720,
								translateY:-100,
								translateX:200,
								xOffset:100,
								yOffset:100,
								scaleX:0,
								scaleY:0
							},5000,function(){
								cs.loader().remove()	
							})	
						}
					},
					5000
				)
			})	
	})
	$(".g-green").click(function(){
		$(".p-green").csChop(
			{
				type:"multi",
				allowMultiChop : true,
				hPieces:10,
				vPieces:20,
				scaleX:1,
				scaleY:1,
				xOffset:-100,
				yOffset:-50,
				scaleX:0,
				scaleY:0,
				rotate:360,
				origin:"20px -10px",
				hidden:true,
				rotateSymmetric:true
			},
			10,
			function(cs){
				cs.loader().show()
				cs.loader().csTransform({transform:"rotate(180deg) scale(1)",time:30000})
				setTimeout(function(){
						
					cs.setTo({
								rotate:720,
								translateY:-1000,
								translateX:300,
								xOffset:-100,
								yOffset:-100,
								scaleX:0,
								scaleY:0,
								pieceDelay:100
					},5000,function(){cs.loader().remove()})
				
				},7000)
				cs.setTo(
					{
						scaleX:1,
						scaleY:1,
						xOffset:300,
						yOffset:300,
						rotate:0,
						pieceDelay:300
						
					},
					5000)
			})	
	})
	$(".g-blue").click(function(){
		$(".p-blue").csChop(
			{
				type:"multi",
				allowMultiChop : true,
				hPieces:10,
				vPieces:20,
				scaleX:1,
				scaleY:1,
				xOffset:-100,
				yOffset:-50,
				scaleX:0,
				scaleY:0,
				rotate:360,
				translateX:-200,
				translateY:-100,
				origin:"20px -10px",
				animateOrigin:true,
				hidden:true,
				rotateSymmetric:true
			},
			10,
			function(cs){
				cs.loader().show()
				cs.loader().csTransform({transform:"rotate(360deg) scale(1)",time:30000})
				cs.setTo(
					{
						scaleX:1,
						scaleY:1,
						xOffset:200,
						yOffset:200,
						rotate:0,
						pieceDelay:100,
						translateX:-200,
						completeFirst: function(){
							cs.fadeToSet(
								{
									image:".p-green",
									xFade:false,
									fadeDur:1000,
									rotate:-360,
									xOffset:-100,
									yOffset:-50,
									scaleX:0,
									scaleY:0,
									pieceDelay:100
								},
								7000,
								function(){cs.loader().remove()}
							)
									
						}
						
					},
					5000
				)
			})	
	})
	$(".icons a").click(function(e){
		e.preventDefault();
		if($(window).scrollTop()>450) {
			$('html,body').animate({scrollTop:200},300)
		}
		
	})
	$(".t-1").click(function(){
		$.chopSlider.slide({
			autoplay:false,
			type: "multi",
			xOffset: 300,
			yOffset: 100,
			hPieces : 10,
			vPieces: 10,
			rotate : 180 ,
			rotateSymmetric: false,
			scaleX:0,
			scaleY:0,
			dur1: 1000,
			dur2 :1,
			dur3: 1000,
			pieceDelay : 100,
			xFadeDelay :0
		})	
	})
	$(".t-2").click(function(){
		$.chopSlider.slide({
			autoplay:false,
			type: "multi",
			xOffset: -400,
			yOffset: 0,
			hPieces : 10,
			vPieces: 10,
			rotate : 720 ,
			rotateSymmetric: false,
			scaleX:0,
			scaleY:0,
			dur1: 1600,
			dur2 :1,
			dur3: 1600,
			pieceDelay : 100,
			xFadeDelay :0
		})	
	})
	$(".t-3").click(function(){
		$.chopSlider.slide({
			autoplay:false,
			type: "multi",
			xOffset: -1000,
			yOffset: 200,
			hPieces : 10,
			vPieces: 10,
			rotate : 720 ,
			rotateSymmetric: false,
			scaleX:0,
			scaleY:0,
			dur1: 1600,
			dur2 :1,
			dur3: 1600,
			pieceDelay : 100,
			xFadeDelay :0
		})	
	})
	$(".t-4").click(function(){
		$.chopSlider.slide({
			autoplay:false,
			type: "vertical",
			xOffset: 100,
			yOffset: 0,
			hPieces : 1,
			vPieces: 40,
			rotate : -10 ,
			rotateSymmetric: false,
			scaleX:0.8,
			scaleY:0.8,
			dur1: 1600,
			dur2 :300,
			dur3: 1600,
			pieceDelay : 100,
			xFadeDelay :0
		})	
	})
	$(".t-5").click(function(){
		$.chopSlider.slide({
			autoplay:false,
			type: "vertical",
			xOffset: 100,
			yOffset: 100,
			hPieces : 1,
			vPieces: 40,
			rotate : -40 ,
			rotateSymmetric: false,
			scaleX:0.8,
			scaleY:0.8,
			dur1: 1000,
			dur2 :300,
			dur3: 1000,
			pieceDelay : 30,
			xFadeDelay :0
		})	
	})
	$(".t-6").click(function(){
		$.chopSlider.slide({
			autoplay:false,
			type: "vertical",
			xOffset: -200,
			yOffset: 300,
			hPieces : 1,
			vPieces: 40,
			rotate : 360 ,
			rotateSymmetric: true,
			scaleX:0,
			scaleY:0,
			ease1:"ease-in",
			ease2:"ease-out",
			origin:"left top",
			dur1: 2000,
			dur2 :1,
			dur3: 2000,
			pieceDelay : 30,
			xFadeDelay :0
		})	
	})
	$(".t-7").click(function(){
		$.chopSlider.slide({
			autoplay:false,
			type: "vertical",
			xOffset: 0,
			yOffset: 0,
			hPieces : 1,
			vPieces: 40,
			rotate : 180 ,
			rotateSymmetric: true,
			scaleX:0,
			scaleY:0,
			dur1: 1200,
			dur2 :1,
			dur3: 1200,
			pieceDelay : 100,
			xFadeDelay :0
		})	
	})
	$(".t-8").click(function(){
		$.chopSlider.slide({
			autoplay:false,
			type: "horizontal",
			xOffset: 0,
			yOffset: 10,
			hPieces : 40,
			vPieces: 40,
			rotate : -10 ,
			rotateSymmetric: true,
			scaleX:0,
			scaleY:1,
			dur1: 900,
			dur2 :1,
			dur3: 900,
			pieceDelay : 50,
			xFadeDelay :0
		})	
	})
	$(".t-9").click(function(){
		$.chopSlider.slide({
			autoplay:false,
			type: "horizontal",
			xOffset: 0,
			yOffset: 50,
			hPieces : 20,
			vPieces: 40,
			rotate : -30 ,
			ease1:"ease-in-out",
			ease2:"ease-in-out",
			rotateSymmetric: false,
			scaleX:0.5,
			scaleY:1,
			dur1: 900,
			dur2 :900,
			dur3: 900,
			pieceDelay : 50,
			xFadeDelay :300
		})	
	})
	$(".t-10").click(function(){
		$.chopSlider.slide({
			autoplay:false,
			type: "vertical",
			xOffset: 100,
			yOffset: 50,
			hPieces : 20,
			vPieces: 40,
			rotate : 45 ,
			rotateSymmetric: false,
			scaleX:1,
			scaleY:1,
			dur1: 900,
			dur2 :900,
			dur3: 900,
			pieceDelay : 50,
			xFadeDelay :300
		})	
	})
	$(".t-11").click(function(){
		$.chopSlider.slide({
			autoplay:false,
			type: "multi",
			xOffset: -500,
			yOffset: -300,
			hPieces : 10,
			vPieces: 10,
			rotate : 90 ,
			rotateSymmetric: false,
			scaleX:0,
			scaleY:0,
			dur1: 2000,
			dur2 :1,
			dur3: 2000,
			pieceDelay : 30,
			xFadeDelay :300
		})	
	})
	$(".t-12").click(function(){
		$.chopSlider.slide({
			autoplay:false,
			type: "multi",
			xOffset: -1000,
			yOffset: -500,
			hPieces : 10,
			vPieces: 10,
			rotate : 90 ,
			rotateSymmetric: false,
			scaleX:0,
			scaleY:0,
			dur1: 2000,
			dur2 :1,
			dur3: 2000,
			pieceDelay : 60,
			xFadeDelay :0
		})	
	})
	$(".t-13").click(function(){
		$.chopSlider.slide({
			autoplay:false,
			type: "multi",
			xOffset: 0,
			yOffset: 0,
			hPieces : 10,
			vPieces: 10,
			rotate : 20 ,
			rotateSymmetric: false,
			scaleX:0,
			scaleY:0,
			translateX:300,
			translateY:-100,
			dur1: 1000,
			dur2 :1,
			dur3: 1000,
			pieceDelay : 100,
			xFadeDelay :0
		})	
	})
	$(".t-14").click(function(){
		$.chopSlider.slide({
			autoplay:false,
			type: "multi",
			xOffset: 0,
			yOffset: 0,
			hPieces : 10,
			vPieces: 10,
			rotate : 10 ,
			rotateSymmetric: false,
			scaleX:0,
			scaleY:0,
			dur1: 1000,
			dur2 :1,
			dur3: 1000,
			pieceDelay : 100,
			xFadeDelay :0
		})	
	})
	$(".t-15").click(function(){
		$.chopSlider.slide({
			autoplay:false,
			type: "multi",
			xOffset: -100,
			yOffset: -100,
			hPieces : 10,
			vPieces: 10,
			rotate : 20 ,
			rotateSymmetric: false,
			scaleX:0,
			scaleY:0,
			dur1: 1000,
			dur2 :1,
			dur3: 1000,
			pieceDelay : 100,
			xFadeDelay :0
		})	
	})
	$(".t-16").click(function(){
		$.chopSlider.slide({
			autoplay:false,
			type: "multi",
			xOffset: 0,
			yOffset: 0,
			hPieces : 5,
			vPieces: 5,
			rotate : 10 ,
			rotateSymmetric: false,
			scaleX:-1,
			scaleY:1,
			dur1: 1300,
			dur2 :600,
			dur3: 1300,
			pieceDelay : 200,
			xFadeDelay :0
		})	
	})
	$(".t-17").click(function(){
		$.chopSlider.slide({
			autoplay:false,
			type: "multi",
			xOffset: 0,
			yOffset: 0,
			hPieces : 5,
			vPieces: 5,
			rotate : 0 ,
			rotateSymmetric: false,
			scaleX:1,
			scaleY:-1,
			dur1: 1400,
			dur2 :900,
			dur3: 1400,
			pieceDelay : 300,
			xFadeDelay :0
		})	
	})
	$(".t-18").click(function(){
		$.chopSlider.slide({
			autoplay:false,
			type: "multi",
			xOffset:100,
			yOffset: 100,
			hPieces : 10,
			vPieces: 10,
			rotate : 20 ,
			rotateSymmetric: false,
			scaleX:-1,
			scaleY:0,
			translateX:500,
			dur1: 1000,
			dur2 :1,
			dur3: 1000,
			pieceDelay : 100,
			xFadeDelay :0
		})	
	})
	$(".t-19").click(function(){
		$.chopSlider.slide({
			autoplay:false,
			type: "horizontal",
			xOffset: 0,
			yOffset: 10,
			hPieces : 40,
			vPieces: 40,
			rotate : 15 ,
			rotateSymmetric: false,
			scaleX:-0.2,
			scaleY:1,
			dur1: 1200,
			dur2 :600,
			dur3: 1200,
			pieceDelay : 50,
			xFadeDelay :0,
			origin:"200px top",
			ease1:"ease-in-out",
			ease2:"ease-in-out"
		})	
	})
	$(".t-20").click(function(){
		$.chopSlider.slide({
			autoplay:false,
			type: "vertical",
			xOffset: 0,
			yOffset: 50,
			hPieces : 40,
			vPieces: 40,
			rotate : -35 ,
			rotateSymmetric: false,
			scaleX:1,
			scaleY:0.6,
			dur1: 1200,
			dur2 :300,
			dur3: 1200,
			pieceDelay : 90,
			xFadeDelay :0,
			origin:"200px top",
			ease1:"ease-in-out",
			ease2:"ease-in-out"
		})		
	})
	$(".t-21").click(function(){
		$.chopSlider.slide({
			autoplay:false,
			type: "vertical",
			xOffset: 0,
			yOffset: 50,
			hPieces : 40,
			vPieces: 40,
			rotate : -35 ,
			rotateSymmetric: false,
			scaleX:-1,
			scaleY:0.6,
			dur1: 1200,
			dur2 :600,
			dur3: 1200,
			pieceDelay : 90,
			xFadeDelay :0,
			origin:"-100px 100px",
			ease1:"ease-in-out",
			ease2:"ease-in-out"
		})		
	})
	$(".t-22").click(function(){
		$.chopSlider.slide({
			autoplay:false,
			type: "multi",
			xOffset: 0,
			yOffset: -100,
			hPieces : 8,
			vPieces: 10,
			rotate : 20 ,
			rotateSymmetric: true,
			scaleX:1,
			scaleY:-0.2,
			dur1: 1200,
			dur2 :600,
			dur3: 1200,
			pieceDelay : 90,
			xFadeDelay :1000,
			origin:"300px 100px",
			ease1:"ease-in-out",
			ease2:"ease-in-out"
		})		
	})
	$(".t-23").click(function(){
		$.chopSlider.slide({
			autoplay:false,
			type: "vertical",
			xOffset: 50,
			yOffset: 0,
			hPieces : 8,
			vPieces: 10,
			rotate : 20 ,
			rotateSymmetric: false,
			scaleX:-1,
			scaleY:1,
			translateX:-400,
			dur1: 1200,
			dur2 :600,
			dur3: 1200,
			pieceDelay : 90,
			xFadeDelay :0,
			origin:"-100px -100px",
			ease1:"ease-in-out",
			ease2:"ease-in-out"
		})		
	})
	$(".t-24").click(function(){
		$.chopSlider.slide({
			autoplay:false,
			type: "multi",
			xOffset: -400,
			yOffset: -400,
			hPieces : 10,
			vPieces: 10,
			rotate : 360 ,
			rotateSymmetric: true,
			scaleX:0,
			scaleY:0,
			dur1: 5000,
			dur2 :100,
			dur3: 5000,
			pieceDelay : 80,
			xFadeDelay :0,
			origin:"right -200px",
			ease1:"ease",
			ease2:"ease"
		})			
	})
	$(".t-25").click(function(){
		$.chopSlider.slide({
			autoplay:false,
			type: "multi",
			xOffset: -400,
			yOffset: -400,
			hPieces : 10,
			vPieces: 10,
			rotate : 720 ,
			rotateSymmetric: false,
			scaleX:0,
			scaleY:0,
			dur1: 5000,
			dur2 :100,
			dur3: 5000,
			pieceDelay : 80,
			xFadeDelay :0,
			origin:"100px -200px",
			ease1:"ease",
			ease2:"ease"
		})		
	})
	$(".t-26").click(function(){
		$.chopSlider.slide({
			autoplay:false,
			type: "horizontal",
			xOffset: 0,
			yOffset: 0,
			hPieces : 40,
			vPieces: 20,
			rotate : 90 ,
			rotateSymmetric: false,
			scaleX:0,
			scaleY:0,
			translateX:1000,
			translateY:-1000,
			dur1: 2000,
			dur2 :1,
			dur3: 2000,
			pieceDelay : 0,
			xFadeDelay :0,
			origin:"center center",
			ease1:"cubic-bezier(1.0, 1.5, 0.0, 1.0)",
			ease2:"cubic-bezier(1.0, 1.5, 0.0, 1.0)"
		})		
	})
	$(".t-27").click(function(){
		$.chopSlider.slide({
			autoplay:false,
			type: "horizontal",
			xOffset: 0,
			yOffset: 0,
			hPieces : 40,
			vPieces: 10,
			rotate : 180 ,
			rotateSymmetric: false,
			scaleX:1,
			scaleY:0,
			translateX:1000,
			translateY:-1000,
			dur1: 4000,
			dur2 :1,
			dur3: 4000,
			pieceDelay : 0,
			xFadeDelay :0,
			origin:"center center",
			ease1:"cubic-bezier(1.0, 1.5, 0.0, 1.0)",
			ease2:"cubic-bezier(1.0, 1.5, 0.0, 1.0)"
			
		})		
	})
	$(".t-28").click(function(){
		$.chopSlider.slide({
			autoplay:false,
			type: "vertical",
			xOffset: 0,
			yOffset: 0,
			hPieces : 40,
			vPieces: 40,
			rotate : -180 ,
			rotateSymmetric: false,
			scaleX:0,
			scaleY:0,
			translateX:1000,
			translateY:1000,
			dur1: 2000,
			dur2 :1,
			dur3: 2000,
			pieceDelay : 0,
			xFadeDelay :0,
			origin:"center center",
			ease1:"cubic-bezier(1.0, 1.5, 0.0, 1.0)",
			ease2:"cubic-bezier(1.0, 1.5, 0.0, 1.0)"
			
		})		
	})
	$(".t-29").click(function(){
		$.chopSlider.slide({
			autoplay:false,
			type: "vertical",
			xOffset: 0,
			yOffset: 0,
			hPieces : 40,
			vPieces: 80,
			rotate : -360 ,
			rotateSymmetric: false,
			scaleX:0,
			scaleY:0,
			translateX:1000,
			translateY:1000,
			dur1: 3000,
			dur2 :1,
			dur3: 3000,
			pieceDelay : 10,
			xFadeDelay :0,
			origin:"center center",
			ease1:"cubic-bezier(1.0, 1.5, 0.0, 1.0)",
			ease2:"cubic-bezier(1.0, 1.5, 0.0, 1.0)"
			
		})			
	})
	$(".t-30").click(function(){
		$.chopSlider.slide({
			autoplay:false,
			type: "vertical",
			xOffset: 0,
			yOffset: 0,
			hPieces : 40,
			vPieces: 80,
			rotate : -180 ,
			rotateSymmetric: false,
			scaleX:0,
			scaleY:0,
			translateX:-1000,
			translateY:-1000,
			dur1: 3000,
			dur2 :1,
			dur3: 3000,
			pieceDelay : 10,
			xFadeDelay :0,
			origin:"center center",
			ease1:"ease-in",
			ease2:"ease-out"
			
		})		
	})
	$(".t-31").click(function(){
		$.chopSlider.slide({
			autoplay:false,
			type: "vertical",
			xOffset: 0,
			yOffset: 0,
			hPieces : 40,
			vPieces: 80,
			rotate : -90 ,
			rotateSymmetric: false,
			scaleX:1,
			scaleY:1,
			translateX:-0,
			translateY:-100,
			dur1: 1000,
			dur2 :1000,
			dur3: 1000,
			pieceDelay : 0,
			xFadeDelay :0,
			origin:"center center",
			ease1:"ease-in-out",
			ease2:"ease-in-out"
			
		})			
	})
	$(".t-32").click(function(){
		$.chopSlider.slide({
			autoplay:false,
			type: "multi",
			xOffset: 100,
			yOffset: 100,
			hPieces : 10,
			vPieces: 10,
			rotate : -45 ,
			rotateSymmetric: true,
			scaleX:0,
			scaleY:-1,
			dur1: 1000,
			dur2 :100,
			dur3: 1000,
			pieceDelay : 80,
			translateY:500,
			xFadeDelay :0,
			origin:"center center",
			ease1:"ease",
			ease2:"ease"
		})		
	})
	$(".t-33").click(function(){
		$.chopSlider.slide({
			autoplay:false,
			type: "multi",
			xOffset: 100,
			yOffset: 100,
			hPieces : 10,
			vPieces: 10,
			rotate : -760 ,
			rotateSymmetric: false,
			scaleX:0,
			scaleY:-1,
			dur1: 1000,
			dur2 :100,
			dur3: 1000,
			pieceDelay : 80,
			translateX:0,
			translateY:0,
			xFadeDelay :0,
			origin:"center center",
			ease1:"ease",
			ease2:"ease"
		})		
	})
	$(".t-34").click(function(){
		$.chopSlider.slide({
			autoplay:false,
			type: "multi",
			xOffset: 100,
			yOffset: 100,
			hPieces : 10,
			vPieces: 10,
			rotate : -270 ,
			rotateSymmetric: true,
			scaleX:0,
			scaleY:-1,
			dur1: 2000,
			dur2 :1,
			dur3: 2000,
			pieceDelay : 10,
			translateX:100,
			translateY:-200,
			xFadeDelay :0,
			origin:"left top",
			ease1:"cubic-bezier(1.0, 1.5, 0.0, 1.0)",
			ease2:"cubic-bezier(1.0, 1.5, 0.0, 1.0)"
		})	
	})
	
	$(".t-custom").click(function(){
		if($("#custom-transition").css("display")=="none") {
			$("#custom-transition").slideDown(600)	
		}
		else {
			$("#custom-transition").slideUp(600)
		}
	})
	$("#custom-form").submit(function(e){
		e.preventDefault();
		var a = {};
		a.autoplay = false;	
		a.type = $("#type option:selected").val();
		a.xOffset = $("#xOffset").val()*1;
		a.yOffset = $("#yOffset").val()*1;
		a.hPieces = $("#hPieces").val()*1;
		a.vPieces = $("#vPieces").val()*1;
		a.rotate = $("#rotate").val()*1;
		a.rotateSymmetric = $("#symm option:selected").val()=="true"?true:false;
		a.scaleX = $("#scaleX").val()*1;
		a.scaleY = $("#scaleY").val()*1;
		a.translateX = $("#translateX").val()*1;
		a.translateY = $("#translateY").val()*1;
		a.dur1 = $("#dur1").val()*1;
		a.dur2 = $("#dur2").val()*1;
		a.dur3 = $("#dur3").val()*1;
		a.pieceDelay = $("#pieceDelay").val()*1;
		a.xFadeDelay = $("#xFadeDelay").val()*1;
		var originLeft = $("#originLeft").val();
		var originTop = $("#originTop").val();
		a.origin = originLeft+" "+originTop;
		a.ease="ease";
		$.chopSlider.slide(a);
	})
	
	/* -------------- Kickassable Transition ------------*/
	
	$("#kickassable").click(function(e){
		e.preventDefault();
		if(!$.chopSlider.hasCSS3()) {
			alert("Hey! Your browser didn't support CSS3 transitions!");
			return;	
		}
		var kac = {};
		$(".dark-layer").fadeIn(600,function(){
			$(".slider,#slide-loader,#transitions,#new-methods,#gallery,#generator,#akbt,#content,.csChopper").remove()
			$(".pr-i").delay(8000).fadeIn(8000,function(){
					$(this).csChop({
						type:"horizontal",
						translateX:-1000,
						hPieces:20,
						rotate:-180,
						rotateSymmetric:false,
						pieceDelay:200,
						zIndex:19000,
						scaleX:0,
						scaleY:0	
					},8000,function(pri){kac.pri = pri})	
				})
				$(".pr-3").csChop({
					hPieces:40,
					vPieces:20,
					type:"vertical",
					scaleX:1,
					scaleY:30,
					pieceDelay:0,
					xOffset:-600,
					yOffset:-800,
					translateX:-0,
					translateY:-2600,
					animateOrigin:true,
					hidden:true
				},10,function(pr3){
						pr3.loader().show()
						pr3.setTo({translateY:0,pieceDelay:1000,scaleX:-1,scaleY:1,yOffset:0,xOffset:-900},19000,function(){
							pr3.setTo({xOffset:0,pieceDelay:100,scaleX:1},2000,function(){
								pr3.redefine({type:"horizontal"},function(){
									pr3.setTo({scaleX:0.3,translateX:400,scaleY:0.8,rotate:20,rotateSymmetric:false,pieceDelay:70},3000,function(){
										pr3.setTo({
											translateX:400,
											scaleX:-0.3,
											rotate:-20,
											completeFirst:function(){
												pr3.fadeToSet({image:".pr-4",translateX:-800,scaleX:1,scaleY:1,origin:"left top",pieceDelay:90,rotate:-180,yOffset:0,rotateSymmetric:true},9000,function(){
													pr3.setTo({rotate:0,scaleX:1,scaleY:1,translateX:0,pieceDelay:100},9000,function(){
														pr3.redefine({type:"multi",hPieces:10,vPieces:10,origin:"100px 0px"},function(){
															pr3.setTo({rotate:360,scaleX:0,scaleY:0,translateX:600,translateY:-600},7000,function(){
																pr3.setTo(
																  {rotateSymmetric:false,rotate:10,scaleX:1,scaleY:1,translateX:0,translateY:0,xOffset:30,yOffset:30,pieceDelay:60},
																  16000,
																  function(){
																	  
																		  showWhiteSlides();
																	  
																  }
																)
																kac.pri.setTo({scaleX:1,scaleY:1,translateX:0,rotate:0,pieceDelay:100},12000)
																kac.particles.setTo({scaleX:1,scaleY:1,xOffset:0,yOffset:100,pieceDelay:400,translateX:0,translateY:0,rotate:0,
																	completeFirst:function(){
																		kac.particles.setTo({xOffset:-1200,yOffset:-600,scaleX:0,scaleY:0},10000)
																		
																	}
																},12000)
															})
														})
														
													})	
												})	
											}
											
										},3000)
									})	
								})	
							})	
						})
					
				})
				/* ------ White Slides -----*/
				function showWhiteSlides() {
					$(".white-layer").fadeIn(3500,function(){
						$(".csChopper").remove()
						$(".pr-5").csChop({
							type:"multi",
							xOffset:-1000,
							yOffset:600,
							zIndex:38100,
							scaleX:0,
							scaleY:0,
							rotate:720,
							hidden:true,
							rotateSymmetric:false
						},10,function(pr5){
							pr5.loader().show();
							pr5.setTo({scaleX:1,scaleY:1,rotate:0,xOffset:0,yOffset:0,pieceDelay:500},9000,function(){
								pr5.redefine({hPieces:40,type:"horizontal"},function(){
									pr5.setTo({origin:"100% 50%",scaleX:0, rotate:10,pieceDelay:150,completeFirst:function(){
											pr5.fadeToSet({xFade:false,image:".pr-6",scaleX:1,rotate:0,fadeDur:10},5000,function(){
												pr5.redefine({vPieces:80,type:"vertical"},function(){
													pr5.setTo({origin:"50% 0%",scaleY:-1, rotate:20,pieceDelay:150,completeFirst:function(){
															pr5.fadeToSet({xFade:true,image:".pr-7",scaleY:1,rotate:0,fadeDur:300},5000,function(){
																pr5.redefine({hPieces:10,vPieces:10,type:"multi"},function(){
																	pr5.setTo({origin:"50% 50%",scaleY:-1,sclaleX:-1,xOffset:-1000, yOffset:-500, rotate:360,pieceDelay:250,completeFirst:function(){
																			pr5.fadeToSet({xFade:true,image:".pr-8",scaleY:1,sclaleX:1,rotate:0,xOffset:0, yOffset:0,fadeDur:300},9000,function(){
																				pr5.setTo({origin:"50% 50%",scaleY:-1,sclaleX:-1,xOffset:-1000, yOffset:-600, rotate:360,pieceDelay:250,completeFirst:function(){
																						pr5.fadeToSet({xFade:true,image:".pr-9",scaleY:1,sclaleX:1,rotate:0,xOffset:0, yOffset:0,fadeDur:300},9000,function(){
																								setTimeout(function(){
																									pr5.setTo({pieceDelay:100,translateY:-100,scaleX:0,scaleY:0,xOffset:100,yOffset:100,rotate:360},5000)
																									
																								},2000)
																								setTimeout(function(){
																									$(".white-layer").csChop({zIndex:38000,onStart:function(cs2){cs2.slices().css("background-color","#fff")},type:"multi",hPieces:5,vPieces:5,scaleX:0, scaleY:0, xOffset:-500, translateX:-100, yOffset:-200,rotate:720,rotateSymmetric:false,pieceDelay:400},7000,function(){$(".white-layer,.present-slides,.csChopper").remove()})																									
																								},5000)
																						})
																					}
																				},9000)	
																			})
																		}
																	},9000)
																})	
															})
														}
														
													},6000)
												})
											})
										}
									
									},6000)	
								})	
							})	
						})
					})
				}
				
				/* ------ Particles -----*/
				$(".pr-1").csChop({
					hPieces:10,
					vPieces:10,
					type:"multi",
					scaleX:0,
					scaleY:0,
					pieceDelay:0,
					rotate:360,
					xOffset:-900,
					yOffset:-200,
					translateX:-300,
					hidden:true
					
				},10,function(cs){
					cs.loader().show()	
					
					cs.setTo({
							scaleX:1,
							scaleY:1,
							xOffset:0,
							yOffset:100,
							pieceDelay:400,
							translateX:0,
							rotate:0,
							rotateSymmetric:false,
							origin:"center center",
							completeFirst:function(){fadeSparkles()}
							
					},10000)
					
					function fadeSparkles() {
							cs.fadeToSet(
								{
									image:".pr-2",
									fadeDur:2000,
									xFade:true,
									rotate:360,
									translateX:0,
									translateY:-900,
									xOffset:-1200,
									yOffset:-600,
									scaleX:0,
									scaleY:0
								},
								12000,
								function(){
									kac.particles = cs
								}
							)	
					}
				})
		})	
	})
});
