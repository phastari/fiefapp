<script lang="ts">
  export let id: string;
  export let name: string;
  export let coloredBackground: boolean;
</script>

<style lang="scss">
  .container {
    display: inline-flex;
    flex-direction: row;
    user-select: none;
    &:hover {
      background-color: lightgrey;
    }
  }
</style>

<div class='container' style="background-color: {coloredBackground ? 'red' : ''}" on:click={() => console.log(id)}>
  <span>{name}</span>
</div>