<script lang="ts">
  export let type: string;
  export let amount: number;
  export let upkeep: number;
</script>

<style>
</style>

<div class="row">
  <input readonly bind:value={type} />
  <input readonly bind:value={amount} type="number" />
  <input readonly bind:value={upkeep} type="number" />
</div>
