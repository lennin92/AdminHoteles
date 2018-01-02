@ModelType AdminHoteles.PrecioHabitacion
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<div>
    <h4>PrecioHabitacion</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.habitacionId)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.habitacionId)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.precioSugerido)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.precioSugerido)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.precioMinimo)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.precioMinimo)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.desde)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.desde)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.hasta)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.hasta)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.precioHabitacionId }) |
    @Html.ActionLink("Back to List", "Index")
</p>
