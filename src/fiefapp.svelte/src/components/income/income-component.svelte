<script lang="ts">
  export let name: string;
  export let base: number | undefined = undefined;
  export let silver: number | undefined = undefined;
  export let stone: number | undefined = undefined;
  export let wood: number | undefined = undefined;
</script>

<style>
</style>

<div class="row">
  <input readonly bind:value={name} />
  {#if base !== undefined}
    <input readonly bind:value={base} />
  {:else}<span>base filler</span>{/if}
  {#if silver !== undefined}
    <input readonly bind:value={silver} />
  {:else}<span>silver filler</span>{/if}
  {#if stone !== undefined}
    <input readonly bind:value={stone} />
  {:else}<span>stone filler</span>{/if}
  {#if wood !== undefined}
    <input readonly bind:value={wood} />
  {:else}<span>wood filler</span>{/if}
  <select>
    <option />
  </select>
</div>
