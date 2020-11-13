<script lang="ts">
  export let name: string;
  export let daysworkThisYear: number;
  export let daysworkBuild: number;
</script>

<style>
</style>

<div class="row">
  <input readonly bind:value={name} />
  <input
    bind:value={daysworkThisYear}
    type="number"
    min={0}
    max={daysworkBuild} />
  <input readonly bind:value={daysworkBuild} type="number" />
  <select>
    <option />
  </select>
</div>
