<script lang="ts">
  import BuildingComponent from './components/building-component.svelte';
  import type { Building } from '../../../models/building';
  import { fiefs, index } from '../../../stores/fiefmanager';

  let buildings: Building[];
  $: buildings = $fiefs[$index].buildings
    .filter(
      (building) =>
        building.woodwork === 0 &&
        building.smithswork === 0 &&
        building.stonework === 0 &&
        building.wood === 0 &&
        building.stone === 0 &&
        building.iron === 0
    )
    .sort((a, b) => a.type.localeCompare(b.type));

  let production: Building[];
  $: production = $fiefs[$index].buildings
    .filter(
      (building) =>
        building.woodwork > 0 ||
        building.smithswork > 0 ||
        building.stonework > 0 ||
        building.wood > 0 ||
        building.stone > 0 ||
        building.iron > 0
    )
    .sort((a, b) => a.type.localeCompare(b.type));
</script>

<style>
</style>

<h2>Byggnader i förläningen</h2>
{#each buildings as { type, amount, upkeep }}
  <BuildingComponent bind:type bind:amount bind:upkeep />
{/each}

<h2>Pågående byggen</h2>
