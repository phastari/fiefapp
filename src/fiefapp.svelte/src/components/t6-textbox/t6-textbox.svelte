<script lang="ts">
  import {
    parseT6Number,
    parseT6String,
  } from '../../utils/t6converter/t6converter';

  export let value: number = 0;
  let stringValue: string = parseT6Number(value);

  const updateValue = () => {
    value = parseT6String(stringValue);
  };

  const onFocus = () => {
    stringValue = parseT6String(stringValue).toString();
  };

  const onBlur = () => {
    let i = parseInt(stringValue);
    if (i !== NaN) {
      stringValue = parseT6Number(i);
    } else {
      stringValue = parseT6Number(value);
    }
  };
</script>

<style>
</style>

<input
  bind:value={stringValue}
  on:change={() => updateValue()}
  on:focus={() => onFocus()}
  on:blur={() => onBlur()} />
