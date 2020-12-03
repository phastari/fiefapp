<script lang="ts">
  export let label: string = '';
  export let value: string = "";
</script>

<style>
  .input {
    font-size: inherit;
    text-align: center;
    width: var(--small-field);
    min-width: var(--small-field-min);
    max-width: var(--small-field-max);
  }

  .label {
    font-size: var(--label-size);
    width: fit-content;
    text-transform: uppercase;
    vertical-align: middle;
    position: absolute;
  }

  .container {
    display: inline-block;
  }
</style>

<div class="container">
  <label class="label" for="input">{label}</label>
  <input id="input-small-text-field" class="input" type="text" bind:value={value} />
</div>
