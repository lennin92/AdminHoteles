@ModelType AdminHoteles.TipoHabitacion
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<div>
    <h4>TipoHabitacion</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.nombreTipoHabitacion)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.nombreTipoHabitacion)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.tipoHabitacionId }) |
    @Html.ActionLink("Back to List", "Index")
</p>
