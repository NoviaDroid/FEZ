﻿// Type: Newtonsoft.Json.Schema.JsonSchemaNodeCollection
// Assembly: Newtonsoft.Json, Version=4.5.0.0, Culture=neutral, PublicKeyToken=30ad4fe6b2a6aeed
// MVID: DB013E7B-84E7-4AE6-A132-56DC73318C48
// Assembly location: F:\Program Files (x86)\FEZ\Newtonsoft.Json.dll

using System.Collections.ObjectModel;

namespace Newtonsoft.Json.Schema
{
  internal class JsonSchemaNodeCollection : KeyedCollection<string, JsonSchemaNode>
  {
    protected override string GetKeyForItem(JsonSchemaNode item)
    {
      return item.Id;
    }
  }
}
