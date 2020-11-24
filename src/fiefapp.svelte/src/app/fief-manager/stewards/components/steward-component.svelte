<script>
  import T6Textbox from '../../../../components/t6-textbox/t6-textbox.svelte';

  export let name: string;
  export let age: number;
  export let skill: number;
</script>

<style>
</style>

<div class="row">
  <input bind:value={name} />
  <input bind:value={age} type="number" />
  <T6Textbox bind:value={skill} />
</div>
