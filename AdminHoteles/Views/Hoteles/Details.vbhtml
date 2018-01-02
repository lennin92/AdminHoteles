@ModelType AdminHoteles.Hotel
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

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
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.hotelId }) |
    @Html.ActionLink("Back to List", "Index")
</p>
