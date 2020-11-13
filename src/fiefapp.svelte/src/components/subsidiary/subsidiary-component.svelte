<script lang="ts">
  export let name: string;
  export let quality: number;
  export let developmentLevel: number;
  export let silver: number | undefined;
  export let base: number | undefined;
  export let luxury: number | undefined;
  export let daysworkThisYear: number;
  export let daysworkUpkeep: number;
</script>

<style>
</style>

<div class="row">
  <input readonly bind:value={name} />
  <input bind:value={quality} min={0} max={5} />
  <input bind:value={developmentLevel} min={0} />
  {#if silver !== undefined}
    <input readonly bind:value={silver} />
  {:else}silver filler{/if}
  {#if base !== undefined}
    <input readonly bind:value={base} />
  {:else}base filler{/if}
  {#if luxury !== undefined}
    <input readonly bind:value={luxury} />
  {:else}luxury filler{/if}
  <input
    bind:value={daysworkThisYear}
    type="number"
    min={0}
    max={daysworkUpkeep} />
  <input readonly bind:value={daysworkUpkeep} type="number" />
  <select>
    <option />
  </select>
</div>
