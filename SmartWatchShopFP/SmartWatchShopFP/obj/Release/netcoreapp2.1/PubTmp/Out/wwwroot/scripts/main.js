// Accordion
let acc = document.getElementsByClassName("accordion-faq");
let i;

for (i = 0; i < acc.length; i++) {
    acc[i].addEventListener("click", function () {
        this.classList.toggle("activefaq");
        let panel = this.nextElementSibling;
        if (panel.style.maxHeight) {
            panel.style.maxHeight = null;
        } else {
            panel.style.maxHeight = panel.scrollHeight + "px";
        }
    });


}
// Header On Scroll Background Color Change
$(document).ready(function () {
    $(window).scroll(function () {
        var scroll = $(window).scrollTop();
        if (scroll > 100) {
            $(".nav-main").css("background", "#04091E");
        }
        else {
            $(".nav-main").css("background", "");
        }
    })
})

//Open Side Navigation Panel on Mobile Screens
function openNav() {
    document.getElementById("mySidebar").style.width = "250px";
}

function closeNav() {
    document.getElementById("mySidebar").style.width = "0";
}
//Smooth scroll from href
$(document).ready(function () {
    $('a[href*=\\#]').on('click', function (e) {
        e.preventDefault();
        $('html, body').animate({
            scrollTop: $(this.hash).offset().top
        }, 1000);
    });
});

// Dropdown For SidePanel
// var dropdown = document.getElementsByClassName("droplist-panel");
// var x;

// for (x = 0; x < dropdown.length; x++) {
//   dropdown[x].addEventListener("click", function() {
//   this.classList.toggle("active");
//   var dropdownContent = this.nextElementSibling;
//   if (dropdownContent.style.display === "block") {
//   dropdownContent.style.display = "none";
//   } else {
//   dropdownContent.style.display = "block";
//   }
//   });
// }

$(document).on("click", ".additemtocart", function (e) {

    var proId = ($(this).parent().attr("data-id"));

    $.ajax({
        url: "/Cart/AddToCart/" + proId,
        success: function (res) {
            if (res.status === 200) {
                $(".cartCount").html(res.data);
                toastr.options = {
                    "closeButton": true,
                    "progressBar": false,
                    "positionClass": "toast-top-left",
                    "showDuration": "1000",
                    "timeOut": "5000",
                    "type": "info"
                };

                toastr.info(res.message);

            }
        }
    });
});

$(function () {
    var a = document.getElementsByClassName("totalPrice");

    var sum = 0;
    $(a).each(function () {
        sum += + parseInt(this.innerText);
    });

     $("#totalSumm").text(sum);

   
});