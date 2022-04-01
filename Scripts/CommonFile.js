
alert("Welcome to Common file");
var btnMoveToTop = document.getElementById("moveToTop");
function scrollFunction() {

    if (document.body.scrollTop > 20 || document.documentElement.scrollTop > 20) {
        btnMoveToTop.style.display = "block";
    } else {
        btnMoveToTop.style.display = "none";
    }
}

// When the user clicks on the button, scroll to the top of the document
function topFunction() {
    //document.body.scrollTop = 0; // For Safari
    //document.documentElement.scrollTop = 0; // For Chrome, Firefox, IE and Opera

    $('html, body').animate({ scrollTop: 0 }, 'slow');
}

// When the user clicks on the button, Modal Element will close

function closeModalWindow(event) {
    if (event.target == modal) {
        modal.style.display = "none";
        alert(1);
    }

}


// This toggles the menu in dashboard
function toggleMenu(currentId) {
    var currentElement = get(currentId)
    var displayStatus = currentElement.style.display;

    var list = document.getElementsByClassName("p");
    for (var i = 0; i < list.length; i++) {
        list[i].style.display = "none";
    }

    if (displayStatus == "block") {
        currentElement.style.display = "none";
    } else {
        currentElement.style.display = "block";
    }
}
//displays te preloader of any page or action
function showLoader() {
    setTimeout(showPage, 900);
}

// reduces the size of the menu to custom icons

function reduceSideMenu() {
    try {
        // alert("button clicked");
        var sideMenuReduce = document.getElementById("MenuParent");

        if (this.isReduced == undefined) {
            sideMenuReduce.style.width = "200px";
            this.isReduced = true;
        }
        else {
            sideMenuReduce.style.width = "50px";
            this.isReduced = undefined;

        }
    }
    catch (e) {
        alert(e.message())
    }

}


//Displays the dynamic menus in dashboard
function initializeHeaderMenu() {
    var list = document.getElementsByClassName("hl");

    //var list = document.getElementsByClassName("hl");
    for (var i = 0; i < list.length; i++) {
        addHandler(list[i], "click", function (evt) {
            // invokeIframe("changeHeaderMenu", evt)

            if (evt.target.className.match("hl") != null) {
                clearMenu("hl", "hl header-menu")
                evt.target.className = "hl header-menu-selected";
                var d = get(evt.target.dataset.page);
                if (activeDiv != d) {
                    $(activeDiv).hide("fast", function () {
                        $(d).show("slow", function () {
                            /* resizing()*/
                        })
                        activeDiv = d;
                    });
                }

            }
            else {
                clearMenu("hl", "hl header-menu")
            }
        })

    }
}


//erase the selected html elements
function clearMenu(selector, _default) {
    var list = document.getElementsByClassName(selector)
    for (var i = 0; i < list.length; i++) {
        list[i].className = _default;
    }
}

// controls the database assync communication
function JqueryAjaxServiceCall(serviceData, methodToCall, serviceUrl, successMethod) {

    var _url = serviceUrl + "/" + methodToCall
    return $.ajax({
        type: "POST",
        contentType: "application/json; charset=utf-8",
        url: _url,
        data: serviceData,
        dataType: "json",
        success: successMethod,
        error: function (msg) {

            alert(msg.responseText);
        }
    });
    //$.getJSON(serviceUrl + "/" + methodToCall, serviceData, successMethod)
    // $.post(serviceUrl + "/" + methodToCall, serviceData, successMethod,"json")


}
// handles hide and show of the element that holds the loader
function showPage() {
    document.getElementById("loader").style.display = "none";
    document.getElementById("myDiv").style.display = "block";
}
//used to Identof the Id of elements
function get(id, parent) {

    if (parent != undefined) {
        return parent.querySelector("#" + id)
    } else {
        return document.getElementById(id);
    }
}

// used to clear table row that is deleted
function clearContainer(element) {
    while (element.children.length > 0) {
        element.children[0].removeChild(element.children[0]);
    }
}

// to upload te selected image 
function GetSelectedItemValueType(element, message, valueType) {


    var option = element.options[element.selectedIndex];
    if (valueType == "value") {
        if (option.value != "0") {
            return option.value;
        }
        ThrowException(message);
    }
    else {
        if (option.value != "0") {
            return option.innerHTML;
        }
        ThrowException(message);
    }

}

// through exception

function ThrowException(message) {

    var e = new Error();
    e.message = message;

    throw e;
}
// to validate the user input
function checkInput(input, message) {
    var t = input.type;
    if ((t == "text" || t == "email" || t == "number" || t == "data" || t == "time" || t == "color" || t == "tel" || t == "url" || t == "week" || t == "datetime-local" || t == "month") || input.type == "password" || input.type == "textarea") {
        if (input.value.trim() != null && input.value.trim() != "") {
            return input.value;
        }
        ThrowException(message, input, input.VerticalDown)
    }
    else {
        if (input.innerHTML.trim() != null && input.innerHTML.trim() != "") {
            return input.innerHTML
        }
        ThrowException(message, input, input.VerticalDown)
    }

}

//handle the various event
function addHandler(element, event, handler) {
    element.addEventListener(event, handler);
}
// to validate file
function validateFile(file, message) {
    var fileInput = document.getElementById(file);
    var filePath = fileInput.value;
    var allowedExtesions = /(\.jpg | \.jpeg | \.png | \.gif)$/i;
    if (!allowedExtesions.exec(filePath)) {
        alert('Invalid file type');
        fileInput.value = '';
        return false;

    } else {
        //image preview
        if (fileInput.files && fileInput.files[0]) {
            var reader = new fileReader();
            reader.onload = function (e) {
                document.getElementById(e).innerHTML = '<img src="' + e.target.result + '"/>';
            };
            reader.readAsDataURL(fileInput.files[0]);
        }
    }
}

function ImageAnimation(action) {
    var ele = get("loader");

    ele.className = action;
}



function centerAnimation() {
    var ele = get("loader");
    setToCenterOfParent(ele, window)
    ele.className = "show";

}

function setToCenterOfParent(element, parent, vertical) {

    parentWidth = $(parent).width();
    parentHeight = $(parent).height();
    elementWidth = $(element).width();
    elementHeight = parseInt($(element).height());
    //alert(elementHeight + " " + elementWidth)
    $(element).css('left', (parentWidth / 2) - (elementWidth / 2));
    if (vertical == undefined) {
        $(element).css('top', (parentHeight / 2) - (elementHeight / 2));
    } else {
        //$(element).css(vertical, 60);
        $($get("myNav3")).animate({ bottom: "60px" }, 200);

    }

}
