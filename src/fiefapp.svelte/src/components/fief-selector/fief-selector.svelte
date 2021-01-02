<script lang="ts">
  import type { Fief } from '../../models/fief';
  import { fiefs, index} from '../../stores/fiefmanager';

  let selected: Fief;
  $: selected = $fiefs[$index];

  function changeSelection() {
    let newIndex = $fiefs.indexOf(selected);
    // fiefStore.update(() => {
    //   let store = $fiefStore;
    //   store.index = newIndex;
    //   return store;
    // });
    index.update(_ => $fiefs.indexOf(selected))
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
