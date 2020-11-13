<script lang="ts">
  import FiefSelector from '../../../components/fief-selector/fief-selector.svelte';
  import { fiefs, index } from '../../../stores/fiefs';
  import type { Fief } from '../../../models/fief';
  import { cssFontSize } from '../../../actions/css-variables';

  let size: number = 23;
  let fief: Fief;
  $: fief = $fiefs[$index];
</script>

<style>
  h2 {
    font-size: calc(var(--size) * 1px);
  }
</style>

<div class="container">
  <div class="column">
    <div class="row">
      <input bind:value={size} type="range" min="12" max="50" />
    </div>
    <h2 use:cssFontSize={size}>Information</h2>
    <div class="row">
      <FiefSelector />
    </div>
    <div class="row">
      <span>Arvstyp</span>
      <select bind:value={fief.inheritance} />
    </div>
    <div class="row">
      <textarea readonly rows="8" bind:value={fief.inheritance.description} />
    </div>
    <div class="row"><span>Vägnät</span> <select bind:value={fief.road} /></div>
    <div class="row">
      <span>Tunnland</span>
      <input type="number" bind:value={fief.acres} />
    </div>
    <div class="row">
      <span>Jordbruk</span>
      <input type="number" bind:value={fief.farmlandAcres} />
    </div>
    <div class="row">
      <span>Djurhållning</span>
      <input type="number" bind:value={fief.pastureAcres} />
    </div>
    <div class="row">
      <span>Skogsmark</span>
      <input type="number" bind:value={fief.woodlandAcres} />
    </div>
    <div class="row">
      <span>Avverkad skogsmark</span>
      <input type="number" bind:value={fief.fellingAcres} />
    </div>
  </div>
  <div class="column">
    <div class="row">
      <h2>Kvaliter och utvecklingsnivåer</h2>
    </div>
    <div class="row">
      <span>Djurhållning</span>
      <input type="number" bind:value={fief.animalHusbandryQuality} />
      <input type="number" bind:value={fief.animalHusbandryDevelopmentLevel} />
    </div>
    <div class="row">
      <span>Jordbruk</span>
      <input type="number" bind:value={fief.agriculturalDevelopmentLevel} />
      <input type="number" bind:value={fief.agriculturalQuality} />
    </div>
    <div class="row">
      <span>Jakt</span>
      <input type="number" bind:value={fief.huntingQuality} />
      <input type="number" bind:value={fief.huntingDevelopmentLevel} />
    </div>
    <div class="row">
      <span>Fiske</span>
      <input type="number" bind:value={fief.fishingQuality} />
      <input type="number" bind:value={fief.fishingDevelopmentLevel} />
    </div>
    <div class="row">
      <span>Malm</span>
      <input type="number" bind:value={fief.oreQuality} />
      <input type="number" bind:value={fief.oreDevelopmentLevel} />
    </div>
    <div class="row">
      <span>Skogsbruk</span>
      <input type="number" bind:value={fief.woodlandDevelopmentLevel} />
    </div>
    <div class="row">
      <span>Utbildning</span>
      <input type="number" bind:value={fief.educationDevelopmentLevel} />
    </div>
    <div class="row">
      <span>Medicin</span>
      <input type="number" bind:value={fief.healthcareDevelopmentLevel} />
    </div>
    <div class="row">
      <span>Militär</span>
      <input type="number" bind:value={fief.militaryDevelopmentLevel} />
    </div>
    <div class="row">
      <span>Sjöfart</span>
      <input type="number" bind:value={fief.seafaringDevelopmentLevel} />
    </div>
  </div>
</div>
