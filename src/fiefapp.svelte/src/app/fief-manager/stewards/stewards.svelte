<script lang="ts">
  import StewardComponent from '../../../components/steward/steward-component.svelte';
  import { Steward } from '../../../models/steward';
  import { stewards } from '../../../stores/stewards';

  let stewardsList: Steward[];
  $: stewardsList = $stewards;
</script>

<style>
</style>

{#each stewardsList as { name, age, skill }}
  <StewardComponent bind:name bind:age bind:skill />
{/each}

<button on:click={() => stewards.update((n) => [...n, new Steward()])}>lägg till</button>
