@ModelType AdminHoteles.ReservacionHabitacion
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<div>
    <h4>ReservacionHabitacion</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.habitacionId)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.habitacionId)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.clienteId)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.clienteId)
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

        <dt>
            @Html.DisplayNameFor(Function(model) model.precioAcordado)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.precioAcordado)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.reservacionHabitacionId }) |
    @Html.ActionLink("Back to List", "Index")
</p>
