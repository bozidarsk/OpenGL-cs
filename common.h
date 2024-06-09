#version 440 core

// #pragma cull back|front|off
#pragma cull back

// #pragma blend s d
// where s and d are one of:
// zero
// one
// srccolor
// oneminussrccolor
// dstcolor
// oneminusdstcolor
// srcalpha
// oneminussrcalpha
// dstalpha
// oneminusdstalpha
// constantcolor
// oneminusconstantcolor
// constantalpha
// oneminusconstantalpha
#pragma blend srcalpha oneminussrcalpha

struct Vertex 
{
	vec3 position;
	vec3 normal;
	vec2 uv;
};

struct v2f 
{
	vec3 worldPosition;
	vec2 screenPosition;
	vec3 normal;
	vec2 uv;
};

uniform mat4x4 LOCAL_TO_WORLD_M;
uniform mat4x4 PROJECTION_M;
