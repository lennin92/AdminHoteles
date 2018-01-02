@ModelType AdminHoteles.Hotel
@Code
    ViewData("Title") = "Delete"
End Code

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
<div>
    <h4>Hotel</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.nombreHotel)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.nombreHotel)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.direccionHotel)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.direccionHotel)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.estrellasHotel)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.estrellasHotel)
        </dd>

    </dl>
    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()

        @<div class="form-actions no-color">
            <input type="submit" value="Delete" class="btn btn-default" /> |
            @Html.ActionLink("Back to List", "Index")
        </div>
    End Using
</div>
