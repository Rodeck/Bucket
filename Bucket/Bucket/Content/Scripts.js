$(document).ready(function () {

    $("#people").on("keyup change", function () {
        var searchTerm = $(this).val();
        $.get("/Group/SearchForPeople", { searchTerm: searchTerm }, function (data) {
            $("#loadedPeople").html(data);
        });
    });

    $(".person").on("click", function () {

        var li = $(this).closest(".list-group-item").detach();

        if ($(this).hasClass("person-not-added")) {
            
            $('#addedPeopleTable').append(li);
            $(this).removeClass("person-not-added");
        }
        else
        {
            $('#loadedPeople').append(li);
            $(this).addClass("person-not-added");
        }
        
    });


    $("#addGroup").on("click", function (e) {
        e.preventDefault();

        $.ajax({
            url: "/Group/AddGroup",
            type: "post"
        })
       .done(function (result) {
           $(".content-col").html(result);;
       });
    });
});



