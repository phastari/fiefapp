<script lang="ts">
  import BuildingSubsidiaryComponent from '../../../components/subsidiary/building-subsidiary-component.svelte';
  import SubsidiaryComponent from '../../../components/subsidiary/subsidiary-component.svelte';
  import { Subsidiary } from '../../../models/industries/subsidiary';
  import { fiefs, index } from '../../../stores/fiefs';

  let subsidiaries: Subsidiary[];
  $: subsidiaries = $fiefs[$index].industries
    .filter(
      (industry) =>
        industry instanceof Subsidiary && industry.daysworkBuild === 0
    )
    .sort((a, b) => a.name.localeCompare(b.name)) as Subsidiary[];

  let building: Subsidiary[];
  $: building = $fiefs[$index].industries
    .filter(
      (industry) => industry instanceof Subsidiary && industry.daysworkBuild > 0
    )
    .sort((a, b) => a.name.localeCompare(b.name)) as Subsidiary[];

  const openAddSubsidiary = (type: string) => {};
</script>

<style>
</style>

<h2>Binäringar som byggs</h2>
{#each building as { name, daysworkThisYear, daysworkBuild }}
  <BuildingSubsidiaryComponent
    bind:name
    bind:daysworkThisYear
    bind:daysworkBuild />
{/each}
<button on:click={() => openAddSubsidiary('build')}>lägg till</button>

<h2>Binäringar</h2>
{#each subsidiaries as { name, daysworkThisYear, daysworkUpkeep, quality, silver, base, luxury, developmentLevel }}
  <SubsidiaryComponent
    bind:name
    bind:daysworkThisYear
    bind:daysworkUpkeep
    bind:quality
    bind:silver
    bind:base
    bind:luxury
    bind:developmentLevel />
{/each}
<button on:click={() => openAddSubsidiary('done')}>lägg till</button>
