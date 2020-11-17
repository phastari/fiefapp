<script lang="ts">
  import type { Fief } from '../../models/fief';
  import { index, fiefs } from '../../stores/fiefs';

  let selected: Fief;
  $: selected = $fiefs[$index];

  function changeSelection() {
    let newIndex = $fiefs.indexOf(selected);
    index.set(newIndex);
  }
</script>

<style>
</style>

<!-- svelte-ignore a11y-no-onchange -->
<select class="large-field" bind:value={selected} on:change={() => changeSelection()}>
  {#each $fiefs as fief}
    <option value={fief}>{fief.name}</option>
  {/each}
</select>
