// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: citadel_clientmessages.proto
// </auto-generated>

#region Designer generated code
#pragma warning disable CS0612, CS0618, CS1591, CS3021, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
namespace SteamKit2.GC.Deadlock.Internal
{

    [global::ProtoBuf.ProtoContract()]
    public partial class CCitadelClientMsg_Pause : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CCitadelClientMsg_MapPing : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public CMsgVector ping_location { get; set; }

        [global::ProtoBuf.ProtoMember(2)]
        public int event_type
        {
            get => __pbn__event_type.GetValueOrDefault();
            set => __pbn__event_type = value;
        }
        public bool ShouldSerializeevent_type() => __pbn__event_type != null;
        public void Resetevent_type() => __pbn__event_type = null;
        private int? __pbn__event_type;

        [global::ProtoBuf.ProtoMember(3)]
        [global::System.ComponentModel.DefaultValue(-1)]
        public int entity_index
        {
            get => __pbn__entity_index ?? -1;
            set => __pbn__entity_index = value;
        }
        public bool ShouldSerializeentity_index() => __pbn__entity_index != null;
        public void Resetentity_index() => __pbn__entity_index = null;
        private int? __pbn__entity_index;

        [global::ProtoBuf.ProtoMember(4)]
        public bool is_aggressive_ping
        {
            get => __pbn__is_aggressive_ping.GetValueOrDefault();
            set => __pbn__is_aggressive_ping = value;
        }
        public bool ShouldSerializeis_aggressive_ping() => __pbn__is_aggressive_ping != null;
        public void Resetis_aggressive_ping() => __pbn__is_aggressive_ping = null;
        private bool? __pbn__is_aggressive_ping;

        [global::ProtoBuf.ProtoMember(5)]
        public bool is_minimap_ping
        {
            get => __pbn__is_minimap_ping.GetValueOrDefault();
            set => __pbn__is_minimap_ping = value;
        }
        public bool ShouldSerializeis_minimap_ping() => __pbn__is_minimap_ping != null;
        public void Resetis_minimap_ping() => __pbn__is_minimap_ping = null;
        private bool? __pbn__is_minimap_ping;

        [global::ProtoBuf.ProtoMember(6)]
        public bool is_blind_ping
        {
            get => __pbn__is_blind_ping.GetValueOrDefault();
            set => __pbn__is_blind_ping = value;
        }
        public bool ShouldSerializeis_blind_ping() => __pbn__is_blind_ping != null;
        public void Resetis_blind_ping() => __pbn__is_blind_ping = null;
        private bool? __pbn__is_blind_ping;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CCitadelClientMsg_PingWheel : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public uint ping_wheel_option_id
        {
            get => __pbn__ping_wheel_option_id.GetValueOrDefault();
            set => __pbn__ping_wheel_option_id = value;
        }
        public bool ShouldSerializeping_wheel_option_id() => __pbn__ping_wheel_option_id != null;
        public void Resetping_wheel_option_id() => __pbn__ping_wheel_option_id = null;
        private uint? __pbn__ping_wheel_option_id;

        [global::ProtoBuf.ProtoMember(2)]
        public uint subnav_message_id
        {
            get => __pbn__subnav_message_id.GetValueOrDefault();
            set => __pbn__subnav_message_id = value;
        }
        public bool ShouldSerializesubnav_message_id() => __pbn__subnav_message_id != null;
        public void Resetsubnav_message_id() => __pbn__subnav_message_id = null;
        private uint? __pbn__subnav_message_id;

        [global::ProtoBuf.ProtoMember(3)]
        public CMsgVector ping_location { get; set; }

        [global::ProtoBuf.ProtoMember(4)]
        [global::System.ComponentModel.DefaultValue(-1)]
        public int entity_index
        {
            get => __pbn__entity_index ?? -1;
            set => __pbn__entity_index = value;
        }
        public bool ShouldSerializeentity_index() => __pbn__entity_index != null;
        public void Resetentity_index() => __pbn__entity_index = null;
        private int? __pbn__entity_index;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CCitadelClientMsg_AbilityPing : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        [global::System.ComponentModel.DefaultValue(-1)]
        public int entity_index
        {
            get => __pbn__entity_index ?? -1;
            set => __pbn__entity_index = value;
        }
        public bool ShouldSerializeentity_index() => __pbn__entity_index != null;
        public void Resetentity_index() => __pbn__entity_index = null;
        private int? __pbn__entity_index;

        [global::ProtoBuf.ProtoMember(2)]
        public uint pinged_ability_id
        {
            get => __pbn__pinged_ability_id.GetValueOrDefault();
            set => __pbn__pinged_ability_id = value;
        }
        public bool ShouldSerializepinged_ability_id() => __pbn__pinged_ability_id != null;
        public void Resetpinged_ability_id() => __pbn__pinged_ability_id = null;
        private uint? __pbn__pinged_ability_id;

        [global::ProtoBuf.ProtoMember(3)]
        [global::System.ComponentModel.DefaultValue(-1)]
        public int pinged_player_slot
        {
            get => __pbn__pinged_player_slot ?? -1;
            set => __pbn__pinged_player_slot = value;
        }
        public bool ShouldSerializepinged_player_slot() => __pbn__pinged_player_slot != null;
        public void Resetpinged_player_slot() => __pbn__pinged_player_slot = null;
        private int? __pbn__pinged_player_slot;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CCitadelClientMsg_MapLine : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public CMsgMapLine mapline { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CCitadelClientMsg_QuickResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public uint ping_wheel_message_id
        {
            get => __pbn__ping_wheel_message_id.GetValueOrDefault();
            set => __pbn__ping_wheel_message_id = value;
        }
        public bool ShouldSerializeping_wheel_message_id() => __pbn__ping_wheel_message_id != null;
        public void Resetping_wheel_message_id() => __pbn__ping_wheel_message_id = null;
        private uint? __pbn__ping_wheel_message_id;

        [global::ProtoBuf.ProtoMember(2)]
        public uint responding_to_ping_message_id
        {
            get => __pbn__responding_to_ping_message_id.GetValueOrDefault();
            set => __pbn__responding_to_ping_message_id = value;
        }
        public bool ShouldSerializeresponding_to_ping_message_id() => __pbn__responding_to_ping_message_id != null;
        public void Resetresponding_to_ping_message_id() => __pbn__responding_to_ping_message_id = null;
        private uint? __pbn__responding_to_ping_message_id;

        [global::ProtoBuf.ProtoMember(3)]
        [global::System.ComponentModel.DefaultValue(-1)]
        public int responding_to_player_slot
        {
            get => __pbn__responding_to_player_slot ?? -1;
            set => __pbn__responding_to_player_slot = value;
        }
        public bool ShouldSerializeresponding_to_player_slot() => __pbn__responding_to_player_slot != null;
        public void Resetresponding_to_player_slot() => __pbn__responding_to_player_slot = null;
        private int? __pbn__responding_to_player_slot;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CCitadelClientMsg_PerformanceStats : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public float current_game_time
        {
            get => __pbn__current_game_time.GetValueOrDefault();
            set => __pbn__current_game_time = value;
        }
        public bool ShouldSerializecurrent_game_time() => __pbn__current_game_time != null;
        public void Resetcurrent_game_time() => __pbn__current_game_time = null;
        private float? __pbn__current_game_time;

        [global::ProtoBuf.ProtoMember(2)]
        public float average_fps
        {
            get => __pbn__average_fps.GetValueOrDefault();
            set => __pbn__average_fps = value;
        }
        public bool ShouldSerializeaverage_fps() => __pbn__average_fps != null;
        public void Resetaverage_fps() => __pbn__average_fps = null;
        private float? __pbn__average_fps;

        [global::ProtoBuf.ProtoMember(3)]
        public float min_fps
        {
            get => __pbn__min_fps.GetValueOrDefault();
            set => __pbn__min_fps = value;
        }
        public bool ShouldSerializemin_fps() => __pbn__min_fps != null;
        public void Resetmin_fps() => __pbn__min_fps = null;
        private float? __pbn__min_fps;

        [global::ProtoBuf.ProtoMember(4)]
        public float max_fps
        {
            get => __pbn__max_fps.GetValueOrDefault();
            set => __pbn__max_fps = value;
        }
        public bool ShouldSerializemax_fps() => __pbn__max_fps != null;
        public void Resetmax_fps() => __pbn__max_fps = null;
        private float? __pbn__max_fps;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CCitadelClientMsg_ChatMsg : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        [global::System.ComponentModel.DefaultValue("")]
        public string chat_text
        {
            get => __pbn__chat_text ?? "";
            set => __pbn__chat_text = value;
        }
        public bool ShouldSerializechat_text() => __pbn__chat_text != null;
        public void Resetchat_text() => __pbn__chat_text = null;
        private string __pbn__chat_text;

        [global::ProtoBuf.ProtoMember(2)]
        public bool all_chat
        {
            get => __pbn__all_chat.GetValueOrDefault();
            set => __pbn__all_chat = value;
        }
        public bool ShouldSerializeall_chat() => __pbn__all_chat != null;
        public void Resetall_chat() => __pbn__all_chat = null;
        private bool? __pbn__all_chat;

        [global::ProtoBuf.ProtoMember(3)]
        [global::System.ComponentModel.DefaultValue(CMsgLaneColor.k_ELaneColor_Invalid)]
        public CMsgLaneColor lane_color
        {
            get => __pbn__lane_color ?? CMsgLaneColor.k_ELaneColor_Invalid;
            set => __pbn__lane_color = value;
        }
        public bool ShouldSerializelane_color() => __pbn__lane_color != null;
        public void Resetlane_color() => __pbn__lane_color = null;
        private CMsgLaneColor? __pbn__lane_color;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CCitadelClientMsg_PerfReport : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public float average_frame_time
        {
            get => __pbn__average_frame_time.GetValueOrDefault();
            set => __pbn__average_frame_time = value;
        }
        public bool ShouldSerializeaverage_frame_time() => __pbn__average_frame_time != null;
        public void Resetaverage_frame_time() => __pbn__average_frame_time = null;
        private float? __pbn__average_frame_time;

        [global::ProtoBuf.ProtoMember(2)]
        public float max_frame_time
        {
            get => __pbn__max_frame_time.GetValueOrDefault();
            set => __pbn__max_frame_time = value;
        }
        public bool ShouldSerializemax_frame_time() => __pbn__max_frame_time != null;
        public void Resetmax_frame_time() => __pbn__max_frame_time = null;
        private float? __pbn__max_frame_time;

        [global::ProtoBuf.ProtoMember(3)]
        public float average_compute_time
        {
            get => __pbn__average_compute_time.GetValueOrDefault();
            set => __pbn__average_compute_time = value;
        }
        public bool ShouldSerializeaverage_compute_time() => __pbn__average_compute_time != null;
        public void Resetaverage_compute_time() => __pbn__average_compute_time = null;
        private float? __pbn__average_compute_time;

        [global::ProtoBuf.ProtoMember(4)]
        public float max_compute_time
        {
            get => __pbn__max_compute_time.GetValueOrDefault();
            set => __pbn__max_compute_time = value;
        }
        public bool ShouldSerializemax_compute_time() => __pbn__max_compute_time != null;
        public void Resetmax_compute_time() => __pbn__max_compute_time = null;
        private float? __pbn__max_compute_time;

        [global::ProtoBuf.ProtoMember(5)]
        public float average_client_tick_time
        {
            get => __pbn__average_client_tick_time.GetValueOrDefault();
            set => __pbn__average_client_tick_time = value;
        }
        public bool ShouldSerializeaverage_client_tick_time() => __pbn__average_client_tick_time != null;
        public void Resetaverage_client_tick_time() => __pbn__average_client_tick_time = null;
        private float? __pbn__average_client_tick_time;

        [global::ProtoBuf.ProtoMember(6)]
        public float max_client_tick_time
        {
            get => __pbn__max_client_tick_time.GetValueOrDefault();
            set => __pbn__max_client_tick_time = value;
        }
        public bool ShouldSerializemax_client_tick_time() => __pbn__max_client_tick_time != null;
        public void Resetmax_client_tick_time() => __pbn__max_client_tick_time = null;
        private float? __pbn__max_client_tick_time;

        [global::ProtoBuf.ProtoMember(7)]
        public float average_client_simulate_time
        {
            get => __pbn__average_client_simulate_time.GetValueOrDefault();
            set => __pbn__average_client_simulate_time = value;
        }
        public bool ShouldSerializeaverage_client_simulate_time() => __pbn__average_client_simulate_time != null;
        public void Resetaverage_client_simulate_time() => __pbn__average_client_simulate_time = null;
        private float? __pbn__average_client_simulate_time;

        [global::ProtoBuf.ProtoMember(8)]
        public float max_client_simulate_time
        {
            get => __pbn__max_client_simulate_time.GetValueOrDefault();
            set => __pbn__max_client_simulate_time = value;
        }
        public bool ShouldSerializemax_client_simulate_time() => __pbn__max_client_simulate_time != null;
        public void Resetmax_client_simulate_time() => __pbn__max_client_simulate_time = null;
        private float? __pbn__max_client_simulate_time;

        [global::ProtoBuf.ProtoMember(9)]
        public float average_output_time
        {
            get => __pbn__average_output_time.GetValueOrDefault();
            set => __pbn__average_output_time = value;
        }
        public bool ShouldSerializeaverage_output_time() => __pbn__average_output_time != null;
        public void Resetaverage_output_time() => __pbn__average_output_time = null;
        private float? __pbn__average_output_time;

        [global::ProtoBuf.ProtoMember(10)]
        public float max_output_time
        {
            get => __pbn__max_output_time.GetValueOrDefault();
            set => __pbn__max_output_time = value;
        }
        public bool ShouldSerializemax_output_time() => __pbn__max_output_time != null;
        public void Resetmax_output_time() => __pbn__max_output_time = null;
        private float? __pbn__max_output_time;

        [global::ProtoBuf.ProtoMember(11)]
        public float average_wait_for_rendering_to_complete_time
        {
            get => __pbn__average_wait_for_rendering_to_complete_time.GetValueOrDefault();
            set => __pbn__average_wait_for_rendering_to_complete_time = value;
        }
        public bool ShouldSerializeaverage_wait_for_rendering_to_complete_time() => __pbn__average_wait_for_rendering_to_complete_time != null;
        public void Resetaverage_wait_for_rendering_to_complete_time() => __pbn__average_wait_for_rendering_to_complete_time = null;
        private float? __pbn__average_wait_for_rendering_to_complete_time;

        [global::ProtoBuf.ProtoMember(12)]
        public float max_wait_for_rendering_to_complete_time
        {
            get => __pbn__max_wait_for_rendering_to_complete_time.GetValueOrDefault();
            set => __pbn__max_wait_for_rendering_to_complete_time = value;
        }
        public bool ShouldSerializemax_wait_for_rendering_to_complete_time() => __pbn__max_wait_for_rendering_to_complete_time != null;
        public void Resetmax_wait_for_rendering_to_complete_time() => __pbn__max_wait_for_rendering_to_complete_time = null;
        private float? __pbn__max_wait_for_rendering_to_complete_time;

        [global::ProtoBuf.ProtoMember(13)]
        public float average_swap_time
        {
            get => __pbn__average_swap_time.GetValueOrDefault();
            set => __pbn__average_swap_time = value;
        }
        public bool ShouldSerializeaverage_swap_time() => __pbn__average_swap_time != null;
        public void Resetaverage_swap_time() => __pbn__average_swap_time = null;
        private float? __pbn__average_swap_time;

        [global::ProtoBuf.ProtoMember(14)]
        public float max_swap_time
        {
            get => __pbn__max_swap_time.GetValueOrDefault();
            set => __pbn__max_swap_time = value;
        }
        public bool ShouldSerializemax_swap_time() => __pbn__max_swap_time != null;
        public void Resetmax_swap_time() => __pbn__max_swap_time = null;
        private float? __pbn__max_swap_time;

        [global::ProtoBuf.ProtoMember(15)]
        public float average_frame_update_time
        {
            get => __pbn__average_frame_update_time.GetValueOrDefault();
            set => __pbn__average_frame_update_time = value;
        }
        public bool ShouldSerializeaverage_frame_update_time() => __pbn__average_frame_update_time != null;
        public void Resetaverage_frame_update_time() => __pbn__average_frame_update_time = null;
        private float? __pbn__average_frame_update_time;

        [global::ProtoBuf.ProtoMember(16)]
        public float max_frame_update_time
        {
            get => __pbn__max_frame_update_time.GetValueOrDefault();
            set => __pbn__max_frame_update_time = value;
        }
        public bool ShouldSerializemax_frame_update_time() => __pbn__max_frame_update_time != null;
        public void Resetmax_frame_update_time() => __pbn__max_frame_update_time = null;
        private float? __pbn__max_frame_update_time;

        [global::ProtoBuf.ProtoMember(17)]
        public float average_idle_time
        {
            get => __pbn__average_idle_time.GetValueOrDefault();
            set => __pbn__average_idle_time = value;
        }
        public bool ShouldSerializeaverage_idle_time() => __pbn__average_idle_time != null;
        public void Resetaverage_idle_time() => __pbn__average_idle_time = null;
        private float? __pbn__average_idle_time;

        [global::ProtoBuf.ProtoMember(18)]
        public float max_idle_time
        {
            get => __pbn__max_idle_time.GetValueOrDefault();
            set => __pbn__max_idle_time = value;
        }
        public bool ShouldSerializemax_idle_time() => __pbn__max_idle_time != null;
        public void Resetmax_idle_time() => __pbn__max_idle_time = null;
        private float? __pbn__max_idle_time;

        [global::ProtoBuf.ProtoMember(19)]
        public float average_input_processing_time
        {
            get => __pbn__average_input_processing_time.GetValueOrDefault();
            set => __pbn__average_input_processing_time = value;
        }
        public bool ShouldSerializeaverage_input_processing_time() => __pbn__average_input_processing_time != null;
        public void Resetaverage_input_processing_time() => __pbn__average_input_processing_time = null;
        private float? __pbn__average_input_processing_time;

        [global::ProtoBuf.ProtoMember(20)]
        public float max_input_processing_time
        {
            get => __pbn__max_input_processing_time.GetValueOrDefault();
            set => __pbn__max_input_processing_time = value;
        }
        public bool ShouldSerializemax_input_processing_time() => __pbn__max_input_processing_time != null;
        public void Resetmax_input_processing_time() => __pbn__max_input_processing_time = null;
        private float? __pbn__max_input_processing_time;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CCitadelClientMsg_GetDamageStats : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public uint lobby_player_slot
        {
            get => __pbn__lobby_player_slot.GetValueOrDefault();
            set => __pbn__lobby_player_slot = value;
        }
        public bool ShouldSerializelobby_player_slot() => __pbn__lobby_player_slot != null;
        public void Resetlobby_player_slot() => __pbn__lobby_player_slot = null;
        private uint? __pbn__lobby_player_slot;

        [global::ProtoBuf.ProtoMember(2)]
        [global::System.ComponentModel.DefaultValue("")]
        public string ability_name
        {
            get => __pbn__ability_name ?? "";
            set => __pbn__ability_name = value;
        }
        public bool ShouldSerializeability_name() => __pbn__ability_name != null;
        public void Resetability_name() => __pbn__ability_name = null;
        private string __pbn__ability_name;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CCitadelClientCachedPlayerStats : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public uint version
        {
            get => __pbn__version.GetValueOrDefault();
            set => __pbn__version = value;
        }
        public bool ShouldSerializeversion() => __pbn__version != null;
        public void Resetversion() => __pbn__version = null;
        private uint? __pbn__version;

        [global::ProtoBuf.ProtoMember(2)]
        public global::System.Collections.Generic.List<Stat> stats { get; } = new global::System.Collections.Generic.List<Stat>();

        [global::ProtoBuf.ProtoContract()]
        public partial class Stat : global::ProtoBuf.IExtensible
        {
            private global::ProtoBuf.IExtension __pbn__extensionData;
            global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
                => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

            [global::ProtoBuf.ProtoMember(1)]
            [global::System.ComponentModel.DefaultValue("")]
            public string stat_name
            {
                get => __pbn__stat_name ?? "";
                set => __pbn__stat_name = value;
            }
            public bool ShouldSerializestat_name() => __pbn__stat_name != null;
            public void Resetstat_name() => __pbn__stat_name = null;
            private string __pbn__stat_name;

            [global::ProtoBuf.ProtoMember(2)]
            public ulong all_time_total
            {
                get => __pbn__all_time_total.GetValueOrDefault();
                set => __pbn__all_time_total = value;
            }
            public bool ShouldSerializeall_time_total() => __pbn__all_time_total != null;
            public void Resetall_time_total() => __pbn__all_time_total = null;
            private ulong? __pbn__all_time_total;

            [global::ProtoBuf.ProtoMember(3)]
            public uint all_time_match_max
            {
                get => __pbn__all_time_match_max.GetValueOrDefault();
                set => __pbn__all_time_match_max = value;
            }
            public bool ShouldSerializeall_time_match_max() => __pbn__all_time_match_max != null;
            public void Resetall_time_match_max() => __pbn__all_time_match_max = null;
            private uint? __pbn__all_time_match_max;

            [global::ProtoBuf.ProtoMember(4)]
            public uint all_time_life_max
            {
                get => __pbn__all_time_life_max.GetValueOrDefault();
                set => __pbn__all_time_life_max = value;
            }
            public bool ShouldSerializeall_time_life_max() => __pbn__all_time_life_max != null;
            public void Resetall_time_life_max() => __pbn__all_time_life_max = null;
            private uint? __pbn__all_time_life_max;

        }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CCitadelClientMsg_ExecuteMapUnitAbility : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public int ability_entity_index
        {
            get => __pbn__ability_entity_index.GetValueOrDefault();
            set => __pbn__ability_entity_index = value;
        }
        public bool ShouldSerializeability_entity_index() => __pbn__ability_entity_index != null;
        public void Resetability_entity_index() => __pbn__ability_entity_index = null;
        private int? __pbn__ability_entity_index;

        [global::ProtoBuf.ProtoMember(2)]
        public int target_entity_index
        {
            get => __pbn__target_entity_index.GetValueOrDefault();
            set => __pbn__target_entity_index = value;
        }
        public bool ShouldSerializetarget_entity_index() => __pbn__target_entity_index != null;
        public void Resettarget_entity_index() => __pbn__target_entity_index = null;
        private int? __pbn__target_entity_index;

    }

    [global::ProtoBuf.ProtoContract()]
    public enum ECitadelClientMessages
    {
        CITADEL_CM_MapPing = 1002,
        CITADEL_CM_PerformanceStats = 1003,
        CITADEL_CM_PingWheel = 1004,
        CITADEL_CM_ChatMsg = 1005,
        CITADEL_CM_PerfReport = 1006,
        CITADEL_CM_QuickResponse = 1007,
        CITADEL_CM_Pause = 1008,
        CITADEL_CM_MapLine = 1009,
        CITADEL_CM_AbilityPing = 1010,
        CITADEL_CM_ExecuteMapUnitAbility = 1011,
        CITADEL_CM_GetDamageStats = 1012,
    }

}

#pragma warning restore CS0612, CS0618, CS1591, CS3021, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
#endregion
