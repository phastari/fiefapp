<script lang="ts">
  import IncomeComponent from './components/income-component.svelte';
  import { Income } from '../../../models/industries/income';
  import { Tax } from '../../../models/industries/tax';
  import type { Industry } from '../../../models/industries/industry';
  import { fiefs, index } from '../../../stores/fiefmanager';
  import { Felling } from '../../../models/industries/felling';
  import { Mine } from '../../../models/industries/mine';
  import { Quarry } from '../../../models/industries/quarry';

  let incomes: Industry[];
  $: incomes = $fiefs[$index].industries
    .filter(
      (industry) =>
        (industry instanceof Income && industry.showInIncome) ||
        industry instanceof Tax ||
        industry instanceof Felling ||
        industry instanceof Mine ||
        industry instanceof Quarry
    )
    .sort((a, b) => a.name.localeCompare(b.name));
</script>

<style>
</style>

{#each incomes as { name, base, silver, wood, stone }}
  <IncomeComponent bind:name bind:base bind:silver bind:wood bind:stone />
{/each}
